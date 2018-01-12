CREATE TABLE `tb_stage_record` (
  `stage_record_id` bigint(20) NOT NULL AUTO_INCREMENT,
  `user_id` bigint(20) DEFAULT NULL,
  `point` int(11) DEFAULT NULL,
  `record_time` datetime DEFAULT NULL,
  PRIMARY KEY (`stage_record_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;