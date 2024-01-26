DROP TABLE IF EXISTS CLIENT_SERVICE_LOG;
DROP TABLE IF EXISTS CHANGE_VALUE;
DROP TABLE IF EXISTS CHANGE_STATUS;
DROP TABLE IF EXISTS CLIENT_CHANGE_LOG;
DROP TABLE IF EXISTS CLIENTS;
DROP TABLE IF EXISTS PARENT_GROUPS;
DROP TABLE IF EXISTS WORKERS;
DROP TABLE IF EXISTS GROUPS;

CREATE TABLE GROUPS
(
	GROUP_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	GROUP_NAME TEXT NOT NULL
);


   Insert into groups
   values
    (100,"なし"),
    (101,"フロントエンド開発係長"),
	(null,"バックエンド開発係長"),
    (null,"システム開発課長"),
    (null,"セキュリティ課長"),
	(null,"開発部長"),
	(null,"社長"),
	(null,"会長"),
	(null,"フロントエンド平社員"),
	(null,"偽フルスタック平社員"),
	(null,"インターン");

   
CREATE TABLE WORKERS
(
	WORKER_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	WORKER_NAME TEXT NOT NULL,
	WORKER_BIRTHDAY TEXT NOT NULL,
	WORKER_GROUP_ID INTEGER NOT NULL,
	WORKER_MAIL TEXT NOT NULL,
	WORKER_DELETE_DATE TEXT,
	FOREIGN KEY (WORKER_GROUP_ID) REFERENCES GROUPS(GROUP_ID)
	
);

insert into workers values(1000001,"worker","2000/11/11",101,"example@hcs.ac.jp",null);

--CREATE TRIGGER after_insert_trigger_groups AFTER INSERT ON groups
--FOR EACH ROW
--BEGIN
--	UPDATE GROUPS
--	SET GROUP_ID =  hex(randomblob(4)) || '-' ||
--           hex(randomblob(2)) || '-4' ||
--           substr(hex(randomblob(2)), 2) || '-a' ||
--           substr(hex(randomblob(2)), 2) || '-6' ||
--           substr(hex(randomblob(2)), 2) || hex(randomblob(6))
--	WHERE rowid = NEW.rowid;
--   END;

CREATE TABLE PARENT_GROUPS
(
	GROUP_ID INTEGER NOT NULL,
	GROUP_PARENT_ID INTEGER NOT NULL DEFAULT 100,
	PRIMARY KEY (GROUP_ID,GROUP_PARENT_ID),
	FOREIGN KEY (GROUP_ID) REFERENCES GROUPS(GROUP_ID)
);

Insert into parent_groups
values
	(101,103),
	(102,103),
	(103,105),
	(104,105),
	(105,106),
	(106,107),
	(107,100),
	(108,101),
	(109,101),
	(109,102),
	(110,108);


CREATE TABLE CLIENTS
(
	CLIENT_ID TEXT NOT NULL PRIMARY KEY 
		DEFAULT ((lower(hex(randomblob(4)))) || '-'
		|| (lower(hex(randomblob(2)))) || '-4'
		|| substr((lower(hex(randomblob(3)))), 2) || '-a'
		|| substr(lower(hex(randomblob(1))), 2) || '-'
		|| (lower(hex(randomblob(6))))),
	CLIENT_PASS TEXT NOT NULL,
	CLIENT_SALT TEXT NOT NULL,
	CLIENT_BIRTHDAY TEXT NOT NULL,
	CLIENT_REGISTERED_DATE TEXT NOT NULL,
	CLIENT_GENDER TEXT,
	CLIENT_DELETE_DATE TEXT,
	CHECK (CLIENT_GENDER IN ("男","女","その他") ),
	CHECK (CLIENT_DELETE_DATE >= DATE("NOW"))
);



CREATE TABLE CLIENT_CHANGE_LOG
(
	changer_id INTEGER NOT NULL,
    changer_timestamp TEXT NOT NULL,
    changer_client TEXT NOT NULL,
    changer_change_status_id TEXT NOT NULL,
    changer_change_value_id TEXT NOT NULL,
    changer_before_value TEXT,
    changer_after_value TEXT,
    PRIMARY KEY (changer_id,changer_timestamp,changer_client),
    FOREIGN KEY (changer_id) REFERENCES workers (workers_id),
    FOREIGN KEY (changer_client) REFERENCES client (client_id),
    FOREIGN KEY (changer_change_status_id) REFERENCES change_status (change_status_id),
    FOREIGN KEY (changer_change_value_id) REFERENCES change_value (change_value_id)
);

CREATE TABLE CHANGE_STATUS
(
	CHANGE_STATUS_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	CHANGE_STATUS_NAME TEXT NOT NULL
);

CREATE TABLE CHANGE_VALUE
(
	CHANGE_STATUS_ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
	CHANGE_VALUE_NAME TEXT NOT NULL
);

CREATE TABLE CLIENT_SERVICE_LOG
(
	CLIENT_SERVICE_ID TEXT NOT NULL PRIMARY KEY, 
	CLIENT_SERVICE_CLIENT_ID TEXT NOT NULL,
	CLIENT_SERVICE_TIMESTUMP TEXT NOT NULL,
	CLIENT_SERVICE_GOYA INTEGER NOT NULL DEFAULT 0,
	FOREIGN KEY (CLIENT_SERVICE_CLIENT_ID) REFERENCES CLIENTS(CLIENT_ID)
);



