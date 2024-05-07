create SEQUENCE id start 1;

create table karyawan
(
    id character VARYING(100) default 'ID-' || nextval('id') primary key,
    name character VARYING(100),
    alamat character VARYING(100),
    no_handphone character VARYING(100),
    departemen character VARYING(100)
);