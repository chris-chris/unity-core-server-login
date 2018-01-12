CREATE TABLE `tb_upgrade_info` (
  `upgrade_id` int(11) NOT NULL,
  `upgrade_type` varchar(100) DEFAULT NULL,
  `upgrade_level` int(11) DEFAULT NULL,
  `upgrade_amount` int(11) DEFAULT NULL,
  `upgrade_cost` int(11) DEFAULT NULL,
  PRIMARY KEY (`upgrade_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;