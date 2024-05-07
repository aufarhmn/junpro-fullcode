create or replace function select_all()
returns table
(
    _id character VARYING,
    _name character VARYING,
    _alamat character VARYING,
    _no_handphone character VARYING,
    _departemen character VARYING
) 
    language plpgsql
    AS
'
begin
    return query
    select
        id,
        name,
        alamat,
        no_handphone,
        departemen
    from public.karyawan;
end;
'