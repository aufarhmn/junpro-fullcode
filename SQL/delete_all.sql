create or replace function delete_all()
    returns int 
    AS
'
BEGIN
    delete from public.karyawan;
    if found then
        return 1;
    else
        return 0;
    end if;
END;
'
language plpgsql;