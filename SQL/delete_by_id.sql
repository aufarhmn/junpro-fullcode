create or replace function delete_by_id
(
    _id character VARYING
)
    returns int 
    AS
'
BEGIN
    delete from public.karyawan 
    where id = _id;
    if found then
        return 1;
    else
        return 0;
    end if;
END;
'
language plpgsql;