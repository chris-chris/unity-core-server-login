CREATE TABLE `tb_level_info` (
  `level` int(11) NOT NULL,
  `experience` int(11) DEFAULT NULL,
  `defense` int(11) DEFAULT NULL,
  `health` int(11) DEFAULT NULL,
  `damage` int(11) DEFAULT NULL,
  `speed` int(11) DEFAULT NULL,
  PRIMARY KEY (`level`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;