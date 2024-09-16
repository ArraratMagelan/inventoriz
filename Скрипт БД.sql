CREATE USER admin_sistem WITH PASSWORD 'AdminAdmIN123';
GRANT ALL PRIVILEGES ON DATABASE "peremesh" TO admin_sistem;
ALTER USER admin_sistem WITH SUPERUSER;

CREATE USER MOL_yniversitet WITH PASSWORD 'MOL123mol';
GRANT ALL PRIVILEGES ON DATABASE "peremesh" TO MOL_yniversitet;
ALTER USER MOL_yniversitet WITH SUPERUSER;

create table kategory
(
	id_kategory serial primary key,
	nazvanie varchar(30)
);

create table raspolojenie
(
	id_raspolojenie serial primary key,
	korpus int not null,
	auditory int not null
);

create table roli 
(
	id_roli serial primary key,
	doljnost varchar(40) not null,
	prava_dostupa varchar(40) not null
);

create table polzovatel
(
	id_polzovatel serial primary key,
	FIO varchar(100) not null,
	doljnost varchar(40) not null,
	email varchar(50) not null,
	id_roli int  references roli(id_roli)
);

create table invenoriz
(
	id_invenoriz serial primary key,
	date_inv date not null,
	id_polzovatel int references polzovatel(id_polzovatel)
);

create table imushestvo
(
	id_imushestvo serial primary key,
	nazvanie varchar(40) not null,
	serial_nomer serial,
	inv_nomer bigint not null,
	date_pok date not null,
	costt bigint not null,
	status varchar(40) check(status in('Используется','Сипсано')),
	id_raspolojenie int references raspolojenie(id_raspolojenie),
	id_kategory int references kategory(id_kategory)
);


create table detali_invenoriz
(
	id_detali_invenoriz serial primary key,
	id_invenoriz int references invenoriz(id_invenoriz),
	id_imushestvo int references imushestvo(id_imushestvo),
	comment_in varchar(40) not null
);

create table spisanie
(
	id_spis serial primary key,
	date_spis date not null,
	prishina_spis varchar(100) not null,
	akt_spis varchar(100) not null,
	id_imushestvo int references imushestvo(id_imushestvo),
	id_polzovatel int references polzovatel(id_polzovatel)
);

create table history_peremesh
(
	id_history_peremesh serial primary key,
	id_imushestvo int references imushestvo(id_imushestvo),
	date_peremesh date,
	id_old_mesto int references raspolojenie(id_raspolojenie),
	id_new_mesto int references raspolojenie(id_raspolojenie),
	id_polzovatel int references polzovatel(id_polzovatel)
);


CREATE OR REPLACE FUNCTION generate_detali_invenoriz(p_id_invenoriz INT)
RETURNS VOID AS $$
DECLARE
    current_id_imushestvo INT;
    current_status VARCHAR(40);
    current_inv_nomer BIGINT := 1; 
    negative_counter INT := -1;
	vnest_nom INT := 0;
BEGIN
    FOR current_id_imushestvo IN SELECT id_imushestvo FROM imushestvo LOOP
        SELECT status INTO current_status FROM imushestvo WHERE id_imushestvo = current_id_imushestvo;

        IF current_status = 'Используется' THEN
			vnest_nom:=current_inv_nomer;
            current_inv_nomer := current_inv_nomer + 1; 
        ELSIF current_status = 'Сипсано' THEN
            vnest_nom := negative_counter; 
            negative_counter := 0; 
        END IF;

        INSERT INTO detali_invenoriz (id_invenoriz, id_imushestvo, comment_in)
        VALUES (p_id_invenoriz, current_id_imushestvo, ''); 

        UPDATE imushestvo SET inv_nomer = vnest_nom WHERE id_imushestvo = current_id_imushestvo;
    END LOOP;
END;
$$ LANGUAGE plpgsql;


create or replace view inv
as
select ii.id_invenoriz as Номер_инвентаризации, date_inv as Дата, comment_in as Комментарий, nazvanie as Название,
serial_nomer as Серийный_номер , inv_nomer as Инвентарный номер
from invenoriz ii
join detali_invenoriz di on di.id_invenoriz =ii.id_invenoriz
join imushestvo im on im.id_imushestvo=di.id_imushestvo;


create or replace view spis
as
select sp.date_spis as Дата_списания, sp.prishina_spis as Причина, sp.akt_spis as Акт, im.nazvanie as Название,
im.serial_nomer as Серийный_номер, pp.FIO as ФИО
from spisanie sp
join imushestvo im on im.id_imushestvo=sp.id_imushestvo
join polzovatel pp on pp.id_polzovatel=sp.id_polzovatel;


CREATE OR REPLACE VIEW public.hist
 AS
 SELECT hp.date_peremesh as Дата_перемещения,
    im.nazvanie as Название,
    im.serial_nomer as Серийный номер,
    (rr.korpus || '.'::text) || rr.auditory AS "Старое_место",
    (rn.korpus || '.'::text) || rn.auditory AS "Новое_место",
    pp.fio
   FROM history_peremesh hp
     JOIN imushestvo im ON im.id_imushestvo = hp.id_imushestvo
     JOIN raspolojenie rr ON rr.id_raspolojenie = hp.id_old_mesto
     JOIN raspolojenie rn ON rn.id_raspolojenie = hp.id_new_mesto
     JOIN polzovatel pp ON pp.id_polzovatel = hp.id_polzovatel;
	 
	 
	 

create or replace view immmm
as
select im.nazvanie as Название, im.serial_nomer as Серийный_номер, im.inv_nomer as Инвентраный_номер, 
im.date_pok as Дата_покупки, im.costt as Цена, im.status as Статус, 
rr.korpus || '.' || rr.auditory as расположение, kk.nazvanie as Название_категории
from imushestvo im
join raspolojenie rr on rr.id_raspolojenie=im.id_raspolojenie
join kategory kk on kk.id_kategory=im.id_kategory;