CREATE TABLE `movie` (
	`id` BIGINT(19) NOT NULL AUTO_INCREMENT,
	`name` VARCHAR(80) NOT NULL DEFAULT '' COLLATE 'latin1_swedish_ci',
	`director` VARCHAR(80) NOT NULL DEFAULT '' COLLATE 'latin1_swedish_ci',
	`gender` VARCHAR(20) NOT NULL DEFAULT '' COLLATE 'latin1_swedish_ci',
	`description` VARCHAR(500) NULL DEFAULT '' COLLATE 'latin1_swedish_ci',
	`duration_time` INT NOT NULL,
	`launchdate` DATETIME Not nULL DEFAULT "1800-11-07T15:00:00.000",
	PRIMARY KEY (`id`) USING BTREE
)
COLLATE='latin1_swedish_ci'
ENGINE=InnoDB
AUTO_INCREMENT=2
;
