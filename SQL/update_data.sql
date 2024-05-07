create or replace function update_data
(
    _id character VARYING,
    _name character VARYING,
    _alamat character VARYING,
    _no_handphone character VARYING,
    _departemen character VARYING
)
    returns int 
    AS
'
BEGIN
    update karayawan set
        name = _name,
        alamat = _alamat,
        no_handphone = _no_handphone,
        departemen = _departemen
    where id = _id;
    if found then
        return 1;
    else
        return 0;
    end if;
END;
'
language plpgsql;