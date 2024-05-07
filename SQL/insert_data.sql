create or replace function insert_data
(
    _name character VARYING,
    _alamat character VARYING,
    _no_handphone character VARYING,
    _departemen character VARYING
)
returns int AS
'
begin
    insert into public.karyawan 
    (
        name, 
        alamat, 
        no_handphone, 
        departemen
    ) 
    values (
        _name, 
        _alamat, 
        _no_handphone, 
        _departemen
    );
    if found then
        return 1;
    else
        return 0;
    end if;
end;
'
language plpgsql;