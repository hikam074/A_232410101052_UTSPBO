create table akun_admin (
	id_akun serial primary key,
	username varchar(64) not null,
	password varchar(64) not null
)
;
create table akun_customer (
	id_akun serial primary key,
	username varchar(64) not null,
	password varchar(64) not null
)
;
create table tugas (
	id_tugas serial primary key,
	judul_tugas varchar(128) not null,
	deskripsi varchar(2048) not null,
	deadline date not null
)
;
insert into akun_admin (username, password) values ('1','1');
insert into tugas (judul_tugas, deskripsi, deadline) values ('uts pbo', 'materinya winform', '2024-11-11')