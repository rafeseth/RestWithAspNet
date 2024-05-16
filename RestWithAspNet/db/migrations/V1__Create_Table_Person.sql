CREATE TABLE if not EXISTS person (
	`id` BIGINT(20) NOT NULL auto_increment,
	`first_name` VARCHAR(80) NOT NULL DEFAULT '',
	`last_name` VARCHAR(80) NOT NULL DEFAULT '',
	`address` VARCHAR(150) NOT NULL DEFAULT '',
	`gender` VARCHAR(10) NOT NULL DEFAULT '',
	PRIMARY KEY (`id`)
)
COLLATE='latin1_swedish_ci'
;
