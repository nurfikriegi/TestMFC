CREATE DATABASE db_TestMFC3
GO

USE db_TestMFC
GO

CREATE TABLE ms_storage_location(
	location_id NVARCHAR(10),
	location_name NVARCHAR(100)
);
GO

CREATE TABLE ms_user(
	user_id BIGINT,
	user_name NVARCHAR(20),
	password NVARCHAR(50),
	is_active BIT
);
GO

CREATE TABLE tr_bpkb(
	agreement_number NVARCHAR(100),
	bpkb_no NVARCHAR(100),
	branch_id NVARCHAR(10),
	bpkb_date DATETIME,
	faktur_no NVARCHAR(100),
	faktur_date DATETIME,
	location_id NVARCHAR(10),
	police_no NVARCHAR(20),
	bpkb_date_in DATETIME,
	created_by NVARCHAR(20),
	created_on DATETIME,
	last_updated_by NVARCHAR(20),
	last_updated_on DATETIME
);
GO

INSERT INTO ms_user VALUES ('1', 'jhonUmiro', 'admin1*', 1);
GO
INSERT INTO ms_user VALUES ('2', 'trisNatan', 'admin2@', 1);
GO
INSERT INTO ms_user VALUES ('3', 'hugoRess', 'admin3#', 0);
GO