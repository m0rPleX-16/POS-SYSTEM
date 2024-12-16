-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: posresto_db
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `posresto_db`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `posresto_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;

USE `posresto_db`;

--
-- Table structure for table `categories_tb`
--

DROP TABLE IF EXISTS `categories_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories_tb` (
  `category_id` int(11) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(100) NOT NULL,
  `is_archived` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories_tb`
--

LOCK TABLES `categories_tb` WRITE;
/*!40000 ALTER TABLE `categories_tb` DISABLE KEYS */;
INSERT INTO `categories_tb` VALUES (1,'Bread',0),(2,'Pizza',0),(3,'Juice',0),(4,'Coffee',0),(5,'Softdrinks',0);
/*!40000 ALTER TABLE `categories_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee_tb`
--

DROP TABLE IF EXISTS `employee_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employee_tb` (
  `employee_id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('Admin','Cashier') NOT NULL,
  `status` enum('Active','Inactive') NOT NULL DEFAULT 'Active',
  `is_archived` tinyint(1) NOT NULL DEFAULT 0,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`employee_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee_tb`
--

LOCK TABLES `employee_tb` WRITE;
/*!40000 ALTER TABLE `employee_tb` DISABLE KEYS */;
INSERT INTO `employee_tb` VALUES (1,'Mels','Andrade','admin','8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918','Admin','Active',0,'2024-11-26 06:54:24','2024-12-15 15:30:48'),(2,'Einna Joy','Cadagat','cashier','6ffbc2bee195cc2b7c4204b5a3900fc90db23340ae0be9205ea9eb5f30acf8b1','Cashier','Active',0,'2024-11-30 18:29:25','2024-12-15 15:35:35');
/*!40000 ALTER TABLE `employee_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ingredients_tb`
--

DROP TABLE IF EXISTS `ingredients_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ingredients_tb` (
  `ingredient_id` int(11) NOT NULL AUTO_INCREMENT,
  `ingredient_name` varchar(255) NOT NULL,
  `unit` varchar(50) NOT NULL,
  `stock_quantity` decimal(10,2) DEFAULT NULL,
  `minimum_quantity` decimal(10,2) DEFAULT NULL,
  `expiration_date` date DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT 1,
  `date_added` datetime DEFAULT current_timestamp(),
  `date_updated` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`ingredient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ingredients_tb`
--

LOCK TABLES `ingredients_tb` WRITE;
/*!40000 ALTER TABLE `ingredients_tb` DISABLE KEYS */;
INSERT INTO `ingredients_tb` VALUES (1,'Baking Soda','grams',100.00,20.00,'2024-12-16',0,'2024-12-16 03:00:03','2024-12-16 19:22:40'),(2,'Wheat','grams',70.00,20.00,'2024-12-16',0,'2024-12-16 03:00:16','2024-12-16 19:22:40');
/*!40000 ALTER TABLE `ingredients_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory_transactions_tb`
--

DROP TABLE IF EXISTS `inventory_transactions_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventory_transactions_tb` (
  `transaction_id` int(11) NOT NULL AUTO_INCREMENT,
  `ingredient_id` int(11) NOT NULL,
  `transaction_type` enum('Restock','Usage') NOT NULL,
  `quantity` decimal(10,2) NOT NULL,
  `transaction_date` datetime DEFAULT current_timestamp(),
  `note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`transaction_id`),
  KEY `ingredient_id` (`ingredient_id`),
  CONSTRAINT `inventory_transactions_tb_ibfk_1` FOREIGN KEY (`ingredient_id`) REFERENCES `ingredients_tb` (`ingredient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory_transactions_tb`
--

LOCK TABLES `inventory_transactions_tb` WRITE;
/*!40000 ALTER TABLE `inventory_transactions_tb` DISABLE KEYS */;
INSERT INTO `inventory_transactions_tb` VALUES (1,1,'Usage',15.00,'2024-12-16 03:04:42','Used in an order'),(2,2,'Usage',15.00,'2024-12-16 03:04:42','Used in an order'),(3,1,'Usage',10.00,'2024-12-16 03:08:57','Used in an order'),(4,2,'Usage',10.00,'2024-12-16 03:08:57','Used in an order'),(5,1,'Usage',15.00,'2024-12-16 03:10:12','Used in an order'),(6,2,'Usage',15.00,'2024-12-16 03:10:12','Used in an order'),(7,1,'Restock',30.00,'2024-12-16 03:36:21','almost out of stock'),(8,1,'Usage',10.00,'2024-12-16 03:51:39','Used in an order'),(9,2,'Usage',10.00,'2024-12-16 03:51:39','Used in an order'),(10,1,'Usage',5.00,'2024-12-16 03:58:54','Used in an order'),(11,2,'Usage',5.00,'2024-12-16 03:58:54','Used in an order'),(12,1,'Usage',15.00,'2024-12-16 16:14:36','Used in an order'),(13,2,'Usage',15.00,'2024-12-16 16:14:36','Used in an order'),(14,1,'Usage',5.00,'2024-12-16 16:24:55','Used in an order'),(15,2,'Usage',5.00,'2024-12-16 16:24:55','Used in an order'),(16,1,'Usage',5.00,'2024-12-16 16:39:03','Used in an order'),(17,2,'Usage',5.00,'2024-12-16 16:39:03','Used in an order');
/*!40000 ALTER TABLE `inventory_transactions_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu_items_tb`
--

DROP TABLE IF EXISTS `menu_items_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu_items_tb` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(255) NOT NULL,
  `category_id` int(11) NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `is_available` tinyint(1) DEFAULT 1,
  `image_base64` blob NOT NULL,
  `is_archived` tinyint(1) NOT NULL,
  `date_added` datetime DEFAULT current_timestamp(),
  `date_updated` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`item_id`),
  KEY `fk_items_category` (`category_id`),
  CONSTRAINT `fk_items_category` FOREIGN KEY (`category_id`) REFERENCES `categories_tb` (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu_items_tb`
--

LOCK TABLES `menu_items_tb` WRITE;
/*!40000 ALTER TABLE `menu_items_tb` DISABLE KEYS */;
INSERT INTO `menu_items_tb` VALUES (1,'Bread',1,50.00,1,'�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0x\0\0\0C\0\0\0W���\0\0\0sRGB\0���\0\0\0gAMA\0\0���a\0\0\0	pHYs\0\0�\0\0��o�d\0\0D�IDATx^�wXV��mv��J�  �`�޻�{�ƚ�XR�%Fc�� b�^QA@zz�wlIv�y�q/$�7�e��=�g����X�)�\\���{�Pk���jM\Z!jz���IJ��(�2%�r�k)�\\^D��\0���NA�NM�NK�V�R�A�V����ו���E4j�T�Q+�h�t��t��IӶB�E��7-�\Z�\Z5J��V!}�J��u�F�V]�g���,��\0@jTj�j*���Y(tEY���\"ki��l��B+��$�����/�J-Tl�R���3E�V�R�Q*�(TJT:J�X*1���Ujt*Z���NZ/3�}E��4��5hU92�z#*������b��\\�\n�kv�O�)��\"tz\Z��bY���{�T*�j���:T�bԪ\"�\"J�\n�5\n��N��D�L��X��X�E����P�FkD�� S(P*�(�3�+�S��FY�JI�UI9j��;�/�`m3sؿ<��D�J��IT��(S�Q�̢J�E�2�R�SJ�iT�2$���R�L�,�&�y�ɿ��Ƚ\\��ka[����s~�2b�~Bu�J�������W�\"�M7�Y��Ҵ�ITZ�kF�V-�D�MI�c�n�����*ʠL�C�\"�U>:u\ZM\Z�\0���S����}�Z\r�l\Zˊ(-|L�� N�\\þ\'�~J/6�r�d�\'�������/A؊�\\Z���̓H^���7�L�Ϗ�ԤP�t���ϸ�gGz����y����4y�4���5�*F�j������h�\nɮ���,��o��o^�D��&ۯ�ʑ��Y�N~S����G���r�j\Z��J�AQ�^U�V��<V��E��)Į�ǣͣ�Y؋㓻�k��Fذu�!K��ʇ�#�[<���+��y!׿������d���q�����A�BwB�8��w�����I�NN�\\\nBR��ۻF���s�$l�\"�&�k�*�Q#��1�:���(� \'h�<���m��v�8j?	;��Ƈ�\rsH�z1A���(p\'ɧ���LY�u�\n�S��A�ɢ���6�*��\0��PzЕ\Zr��Z�J��H��X)L��R�Rz�4�<�:9z�k��:�M��J��@U�W�U���u(���O��ڀL]��r�p�C,�4a;Y!�<9�?fF���QJ.m���h�~Ca��d�X��]Sx����~h���(��-�[�ƫ��Q^���3Oc�v���d�,%v�`�n���e����Y!�o�,qW����F/շxU�����,K� �,Ug)��\n���lph�&�7Xgׂ��;���&�������ߞ������L�,B}L80�mNL���a���N��Y:�[S+����Tk2��Q�-��L�BQ �;�R�Ba���\n�Z�^����f��\Z��nV�B�`5*J2��4J�O(S%S�J�\\�de!���\\7�k�>��N8�O�!A�U_tI�+���#���)-��������B��6)}R(�7s��l�,��w|[Nη��l[ί��ʆa$|���^��DS�\ZAY�Y��/Q�M��X�o�Ρ��l�� ��k�Ԩ�)L�4\'��-��6�[S��2ecW6�4�ޑ���ǭ����Kk�����p\'�w{��A��ӎc}Mmω1���8�?܎��8>Ε���y�7ǧu�ج��\\6�;�?�x-C�u\Z��(�\nШ��Tj�J����u�M�\0�Th�R�@!+�LY���-N�E�ҁ�������^1���>�dM��n��N��/yr�3\Z���O\r�)+���,��8��dZH�B/��Y:Ձ�i��^Ѕ+�p��_;��{��xxOCVc���m_�Xx���i,L�\"�2\r����PW���\Z9?�cH��������=Ɉ����s%E��u1��f[�Vls1a�������ɒ��,���0*��p��-[ݬ9:ȍ������ۆ��fpkO@{Yr�˚��֡5\'zt��@�Ys��)��2Ɲ����h��Y^\\�[ǿ=+�\"��Bq�}��ܴTh�ȵ*��|ʔ�yr��ģ�����եo�_�սs��i4�u�����\'��;��;A�8�v�\r��W�9�n<�w�##x-Eq�Ȍ���{��ۆ��!�SB�?������T�1�A��2�C�i��zz�zm\n\r%4�fS_�ǳ�L*\"b����c_K��3%��F^���\\���H�;�=۲ˡ��Yq��]���r�Q�����:��k�!���1�X�v�`EH_��m	�mO@�z9����~�ls7�h_W6ۿ\'movi���N��f����{�;\r�R\'6M�I�:�b���`���^�ZrJKs�}~?�9�T��̻��^��[H�݊��1�I���=>�:��7ޤ<5�ʬ8\Z�q4�ϣ��$;�Ҭ(di(�LF�I��L9�\"�,%�7��^�\\~��Gє��R�{��Ԫ�X�O�6E�=JO�ԦQ_��K}\"ar�ǆ�V�pk�׷y��]��$~̏�Ɨ#	���>���\rqe�}B{�������N�\"b�-��-91Іc�,86����=��eE�[��8М��VD��qd�%�8�KK��Z�۳!�m	a�v�w��͊��v�6\'pB|�O�A���S�2�\nmY*��2Y2O�l�<%���\'P�]���6e�7xeL�Q��,9U�Ej5��j1�]\'��\Z��.�Az�!�rΒu�U�i*\n�Q����</I�N�$�`xB��/*��-ɤ�<�*}:��L�tYT골.��&�u\nU�\\���)ˤ^Gƾ��7i�^o[�tiϷnosu�H��,OC{�[n-��O3vۚ�ǖC��8�Ӆ�/FS�)��˸0�3�:�E`?[�r��)�#���a.�>�I��Av�\ru\"r�Q�p��������`;���ķ�9�X<�Xp��X��^���w���7X�R S��+\n�Q�J��yh����JI�\Z\r��\\������</M\'>t+���cm��ΡF��+si�&�o�OiT�㏕��{].�7iԧ�ͽA���»���F�w��+sP�ݡT���1\r��k3��\n���+/�N����(Q��X���,�FY8��gS���e�z�w���q�������O}J`�w��a�n3���`�G+~=��;g�4�r��=ɑ�ޖ��\"j�;����P���� ��5�l	�o�Qo��-~p�8Jr|����g�[;6vo��6�vi�*GS\Z�Hy�_���&�)�\ZU1�9���I���}ɼ����0�4Oh(˦J��Q����kT��h4��,�*e\"5B���̘��7�(+�Ki�=*����K��Ц�<�k�h(�BWp����Ԉ�*˦L�«:9Ϫ\ni�,�Y��gU\n���<����\Z~�XN���?Tf����ة�|gނn��$�oG.~<������pU�\'��6�:���՜�ڰõ%Q�{s��<��ƣo�sr�%1�<9�̈́c}��d��v�r�p����0�x_+	d�\0]���!N�c%�i���mɱ�v��4eok�z��˵=_�[�o�d�����o\n�VVDI����a�w����˔e]��,m�JT��di�̣�\"m�-�y�i(M�F�B�>M�EE����h,/�\\�EmY�jT�\r-S��P���~��S�ˠ�,�\n]\Z|��e��?>�S[�O}y1�j4��N��R5F��(���>w7�ǿkk|=L��܁}�8�nN�G�y��?�\\!�o.{�Z��Ƅ����]t3G{�+7����/�̡��Hl���	�8��^��W[|�w��X���1�YX��>��f�_Os��뇹�ӳ=�<��{k����	K:�Ril��7g����\0W�U�K�������\"T���Ƚ���6u�4^�e�}U�%OyY�C��	��\'4��S�y��(M�]t����(�T�JCY�%ԕ˨�T�JNCi>/�d��,�U�Y�*�(��.L��F?>��C����*��*��Z��r�^J�>�Ƭp.,��a�Vl0���8�`�76o��)!���!��m�9��m��Xq������[�V��]Dغ�<������߽����\r��aF�0	�#=�T�`�`��!��\r\0��M*ܖ���Dw��Æ�p������Υ5[�LX�f���1*%�y�����\0�\nQ��)+�a��.(�m!--���(�/Q�M�lh�6ufU�D��Tj��ޑTl�p�����QM�*�g���%U�P.�V�mȣ�����\"~l��FECy1?6�yQSHMI6/j�)�dPWZ@�!��u2\Z�sh�,��,���DdW6��{[�9�a��{|nߚ���D�v!bu�^Dy�^�~��I��qp�T��v��lF���<2�$�y\\Y؝S�`/�w_�6���o\'-�ǸK�Y�+��R��.�H,j\\\\9�\r���po��\0[w3g�[�x������� �N�\0�5 ��\0���*���esx��;�-�sm��`�����)��\'T*��&󪺐rU*e�\'��*��m�1�j}\Ze�D*UIT(�xUU���|I���XV̋J��\nxQQ��u���QEuI.x��B�EC��?�(�y��2}:�ڧ4��S]�ϏU�ɏZ��w�i׆��m�6[�[:���s�IX��S�ۚ��.p�aO�t3�ۮ�I�ŕ/��u4��3ܕ#=�`ǩ���\"~�\'�ަ�jC�dwB�Xsj�#!�l9�ӂ��v�z�:Љ�^V���os�um�!aûYr��\r��۱����I�e�H���\\E�t\"U���0���]�J�E�u��\\��R�xD�,E�u)� ���3�3�򪺘y2��T�E�d��>$�a4F�]Jd����=�J�IcI�n�>����Tk�)S����F�u9�Jo��S_!��F-�j�yU^��\n/��&������ߵ-�����ىu���s뷈z�/��;���4.����¡�\Z��~��g|�K[2�.#��*�W>���A\\��N�\0{�Y2؆�I]8�τ�	.�5\'r��S�96�-q�\\9ҫ==�s��	�<ڳǵ%���8=֝��8أ{[�֢[:�c����l��Ŗ§ɿ�)�7X��R��̋���1�� �)4�S�:�$�P�����|i��4�re2��t��i<+ˡޘ)m�2/S�O�Y��ݦQ�M�ΐAcI��\\���\\�ܗ��|_��y��\Z��/jռ���X%�/����I�ҘB�㜝�Sz�ܣL�eI�\\��}Ӹ�sac���Ғ�A�����\Zd��\rS�9����kH�:�sS\\	b�ىn�����tw�GX=ΎK3�	gō�=9;�#�}�9�[�Ǿ^89О�����e���f����\r�f_O3�wi\'���ÌMNm�|t�W�g!�)���\"��2.�X���n*�/�^(�W6,�(W>���	�:�S\nR/�ʹJ�6�R�*TI�?��8}�m��gJ�V���}�y�-��iTk�i0�P\"�-��)�ԔJ�>�V�N#1��gz�WRm��Yy>�n|@~�J�������fx:�Y�7��ז[�L���i$|џ�w����l89ܑ����MpD����3�I���u������ԫ�:�I���L����t#a�\'�g�pkI7\"F[?ٕ�����\'.��J��nM�HK�5��\'F;�ë5��z����umKz��\\��SS��#s�Qpq?��G���P�[Vx�B�\n���(�Ե�`�j�SV|�r�=^�f�̐ο�˨T\'I�\0��$�Z]��)��P%K��saS5Be��F)�h���ʋ%6�m��ȧ�JMCE��s��a�un�����Ԇ�]m�`�.��=���D����^�~�c=;2Ė��D�$bvGʯ��N�\n�׿���H�l ���=ё��vD����L�Nw��\\W�g97Þ�5}��fO�hkb|\\8;�a#��c��i�$�ߕS�l���A����������\'`�#�:������\n�m�*i�K��ROJ��(/y�2����%f\n6\n�K�%�SNSZ|EFũq�*�D�}C�ݦ�@I�dg[�U��W���R���®K����@b�P���*U�|^ժ��4��\n55�|_ƹ���Њ�A��ڒC���lʕ�#I�?�������@��\'���/���N��ۆ{ߌ@w�;�o�ByaW�v�����Ls��h;���L�4W�/�A�HSb�9r~��>��ĝ�Sm�g�����Lt䴏	�kN�LG�\'ZHː�V�����7����0{�{�\"�a���?����\\�-�6��{\'�z�N�ȋ�$���$+�+)\0*Z0��(yz4��{4�Q)�1�.u�T^T�4�vC&/+���F!�P�9�ʲ${����ƒ\\���X^$1W���b��~ߠ�B�?UQ_k�Y]6ڛ���ԝ�v����a�6�rj��^V�.���c��o\"amh��q΄�v��lO���I�	$������P�_G�<n��\"f���4����95����:7Ù[˻;Æ�V\\��B��%W�t��4g\"Ƙqw�7�#�qaA\'��Y6ɌSS�Ԗ�����D�H{�7�L]�L.ڗ��U�LSHA�N�,Đ\Z�6�\Z�*��2�H�\nF\n�8���\nnQ�y̳�ɠ\\��ZM������{��,˸\"%E�M~U��u\ZIe���x��2eϫe�� �a9ue�<�*��4��ki(7���:G�������:��ل�v���3\'V�&��B�l��iN�lJ���C��@�03Y���>d	[�����]��ёK�݈�bG�$\"�[rnfG.��D���\\�����DO�%nvG\"�Xrf��Vv#|�	gg�0Ԅ�Y��Zٝ������^�vDMv%`xk��[�o�����f�M���Z5����ј�!�&��Xʵɯmi��P\'UZ�W��<�Je\"����s�\Z�I\ZD�lL��!��k�ꅊO�Դ�\Zm&��&�M�{K���ب��4�\'���U<���J�3Y	�{9։}nm	�a��6l�y�3K�q�A<9:�[�r�Þ��0���.�ݚ��&�XޛDߥ�\nZA��d�/��G}	cJ�t\"ƙK�^[؅#�I68~���m��ao�}�%���C��/� r�9�>�DMv������Q��w���lI�8{NM��wD����oX���%é�\nG_p�Z�C*d	g]��+찈���$�|���hr�Q�{�&�&�K2y.�{��.q]S�Z\0�AIq��`��Ϳ���|)I\"��Q�*m��S��F\r�l��$~�\'�m��i�����cG��|8��f��;�k������چ�:rj�5A�L��v<���\\9���3�\"?�1��w��g�&[soE/�L��\0kF�T{�.�I��g�rn��d_�����DN��X.���9=݁ˋ;;׉��m	�H�03B&Xrd�%����,ZID�z�.��s�QUt���|^\ZRhP$�-| ��f�۬�xU���j���J�C\Z�O%��(͡B��WU�-�]as+Ղ��R��([#�\0v���]��J�p�&]Z��\Z�t���hoo�޺��h��a��n�a/Bƺ��\'�}g���؅�x��+�[5ƚ�Kz�7�-��\r%%�#F|BR���N��̜���v$dt{�,�A�4IM&���Л��fDO���L\'B}̸�;	K�H*��L�pX=͆��vD�t��|7\"��;˓�QV�1��=�vi�_�Ȧ�\Zɣ��%�re��(�9�ҧ�Bq�j}�j��d3�%��Ȕ�5ޖ\0���X�1�R��o*�i	�J���W-��#)�Qo +i�r��\n]&x��@�9��)�e�<���9�yY6ʉ�6-89ؑ�y���t0Wv�p{�(N�t v�H+Z5ƞ�+0Ƃ�I\\N��\r��M�*��q$��������E�$,�\0N\\ه�	V\\�����DM��,T��OzqMo�F���|bg�qa�����I6��r&d�\'��>Ɂ�q�Lsf�g;JԿ~P��o��G �\rjΝ�@q�2��;�וR[t���8�\"$l���ͱpSf*�2�=��R��T�R&ѠϠV\'�\"i)D�T�E��\\/�U?��$��<++���������\"�W�k��7��q�9�͑���r{��!����ɩ��<>6���3�ڊ���\\�љ��vDNr��s��Ef�j�_�U����9Îk�=��j-�d���yO���1S�8=Ɏ�Y��I�̲��LXؕ3����@�l�v&j�#Ac�93ˁ�q����S���嫾6�|�::��JF�*���ry\nQ�Q��3�=���\'�~��x��	�+nS�G��	P��_��R_�J��T.S<@_x劉�V�TbmCI&O�^��E;�(	Vh�i,+�Q�JBD<\\��E��	ت\"�^�X�OEi*����j�QmǉA��viI�0{�fw��������C��bE�HS�-�M��F��cţ�sxzj\r�	�(��Y�rb�;?߆k�<H\\Տؙ���߉S��I�l��ڰ1�\\Y�.�_]�E�8��r$aqW��q���%GJ�f��$~^g�f�sr�\'�w��	��m�r\\/t�삿\0X//�\0V���\Z��Wxp�K^�Q��My�\r���I�{�j�mj����\n�&�hLE�{�Zm2��;�nR�J�\\�(唅�n��\"�}*��)W��ו�J�V8P���c�����Z.��V!,¨��\\\Zk3)8��33]	�����#x��<�ql�=Q+��n0���H�0��/I\0��.�M��ԁ�s�I:��Ԉ�d����K_�9��s�]���#��\"d���ݏ{K�T�bO.,p�H�w����J��u��>��v��`���:sb�%1�:qr�-�3쉚nM�({NL�ïǻ����߲#��hTz�b��N�Q]��OѦ�� \\j�{&�N� J����K\"���7��?�Ru��2QQJF��Д���̔,Q��ܕ�xsxU[�C�6CQ4�5ǻ�_�+���G?�L8h�{����IR�L� �Vc�o3��!b�7�G��7�\'[F�pu�&;:ʜks�pz�51�{�����U����3��:�1���H\0�[�ȍ��	�h)1X\0)���AN�Xpi^\'���A�&`��s�X{nA\'.,t��\"/	���DOs&�ǌ�3l�Y���D��c����Mwb�Q�\0k:��Z]\Z��/�����+h2(H��1�����ҩR&S-*K�DIe���S�!�\\���E_x�j�p��J)�f�6U�2����\\��$p��S%z���U2)L������2�W�d��p�V������0%txGN���|7�6\r%�w:������3]9>�=��r�Ǟ�!\\ / ��\ZR�|LՕ�\\Y����{:�I��\0��j��U}%���,y�g�ؒ�v��-{ke/Ǵ\'v�H|X7��S91�J*S�M�&l�9�c��eE̤N�	;��X4}�)�tF4�B��Wy����xO�yfH�Xp�2�#I�V�a(�M�&�:]�ԯ\\��˳�d^TfJ,^���B��YRC��5;gR��5��c@\n���k���E�Y\0��<��rccN��į���R��ي�݉[ڇ��H��Cn��-���)��^֓�S�����c�[sza��������\"#n\r�	$��n@�Ts	��˺I��X`�n�TE,��&�d)|r�E�-^�E�Tn~؇k��t j���\0���ŁV���g\ZA�k��DYD���})�z�	;��߃!3e�Y�U����H-VhcTܢ��Fc2U�����cu./�2�3�I�K���7d��D�1m�	\\�4�fa�����\n���-\'��4OR�d����PR�\r�4ԗwq����q�PwsN�8���=��y��\'�|�p��tR��s}Mw?���ޒ77�#���qe�\0	����ɾ���蕔�������ܕ��nDO���n�$+����W����ΕR,�	�\n-�{�ǔ��<$�9n������8sz�3�Gu tbgv5#x�y����_�`��\0�>��HyQQ��R����Y�#��<��a�)�oQ�}@��:ʬsT(oK��\"5))�Ɵ�gI�^h�Ջ���H���zc*����3�Q�}�2�e�4�J�}-���ZF�!��\naw���Kr����=g>�o�{\\��_/�|\\��Վ�Y�Ĭ�K�\'�I<2�{�Fr~YG���rq��3;5ކ����7����Y\\�Kj��D,\'j��w��\'=	�1\'b�5��97ϝ�#�0�=n,�F�G���$�]a��+�-��<�)\"�х��L�J�P�~��	��Ɓ���\'��V�d��h�������Ք��D�u�^@���-W���$�J]��P=/K�\\~�2�-���nIaѫ�\\��CWx�\n�CI\r���B�O�VtK��P|�����}�C).q�h�}Q^@c��JC6/���kS�ǫ�y.�H�����t j�#~=�J�݀��Yڛ�/�p~�P�Dʞ�\\�؝ˋ�8=Ն+zqj��?�˵M#I<>��;�Kդ��dD,���]IX���y�\\�����6\\�߅�S;:Ζ�$�,{my7Nϰ���&/z�Xv$j�\r�{HI�ȩNe��3���sxlN�X���5��O��\0�*�F�tO�8���(ɸD��ڜ���*�)���EU6U�d�bT.@���Ƨ��UR�T��41�\\uEv���j�Ly�j������>�L)�Q�L�T�̳Ҽ׉�\\)Rnȥܐͫ2Q;N����g����ǐqp2~#L96Ȕc}�lC�h[|\'9��q�s�ۡ$�\Z��U^dmB�DK}ԏ�qVDLu���y\Z�����n��Q��ؕ��^ѕ���$1�3ӝ��h�EQ�oO�D����\"<���ΒZNչ�����]���$�7x�G�[9ŕCc:<֒�C\\��\\L���5��\06�T��Pc��6\r�\"�<%��iT>�ʧh��P�y(��ԕ�Q�I����s1<@�{���R�J�D�z�<�ΘL�\\ryY�G�&�Z�c������q����$	��\'	k��%p��Q_%�gi��ujj�\n�}ui!(�.��(3voE�H\'�nO�$\'��w&���d�,�ɑ���0�;����ʞ��5%r�%18>ڜ���m,	{f�������<��G���t��\'Yq���\\[ғ�Qf���$0̄�ynDMs aI7	D�~�/��Xpz���h��[���03G�rr\\G|�r|��Cڲk�+?T�х��_�`�B�A�G̎9(����K��)˻�&����d?<M��	��T�Sx.bWY/��Ӧ�̘͋�\\)�n,{*M���d\'�H�R3^�!��R1l%U�т��{��<n��*�u��x^U�˲�J�yY+��C�Ϯ\'t�=!�m���@��.��ۖ�Y���©O�I�R������R���\\7�u���\\��Uz8�� n�XIE�D|L������ߍ�\0>7Á�1�$|Н�.DMq��<�b;�y��������.m�F�p!|��T&��l۴=љ�}�6�Y*�l��S6�s�L��gx�-��\0V�����Īa����Q4��<+}J��u�Ghs��\"�Re������j�\"��}E�Tl4��z�t�;�Rң(�\"���3dQ�i�8�,����E�R�&-�\"���T��� ��0��D҃9م���Dw&�ǝ\ro4ە���}����H�?��\r\"~��Td���+A��snj\'F����k�� `)q�\'���*\nbW�~`\na>x\"��.�����ǆ�>��S����rԴ���;ۭi�����������PNO�`w�6��w�Ǧ9�7ڒ��mЫr���%�\0�\n��Z2���s�t�Q��:�}�3.R\'z���ey�T�e@m���C<EqA��4\Z��KO��I���<�Ȑ2Z����S�O��,�\nuR�3�ڹjf�3�x�m*C֪�\\�,-�p��b���`N��%f���[9΍/:���|w�-� ���\\�3��㋸��pNOr r�7�z���.Q��bB���8��b�����s�0��I��C�L;��t��|G�J����-�����\r|��)����̱��R�{r�-���9?�+#:?σc#�96ܦ	��6������	��������.����k�Vi���SR���G���DY�-�T��PޢܐNcI��+��W�\r��P�N��՚��[c.E��Ґ�Z��`/\n���Z�}�L�bUi�y^)�U���R��(�Q8M�2�� Ϫ�xYS,�Gz^�G]�S��eI���YT�6�Խ��m\"�ރ=�>��D�r�;�k���(-$��,���������@ԤN����@��w����_ݓ��K��m*)�˹�7��{\'qtLb��q~����0��H�X<ʎ�Q�nǅ9��g���]Ɂ��\"R�]	cE�Ne˞ޭ�fŞ�m	�����������hČ;��Y��b2�&i�6@L����(����Q��<�&��{�P��\n]���\"����K.W>�B\"1`[xϥE��V%K�W�:�j1:�����^T��O.u%9ԈNJCU���F�(��1IұƊ�\r�<�ΧNĻ�bf�l�ŶJ��&?��ڗ}86����<��|�\rG��4�gV\"xUo����	�h���=kF�h`�ݝC}�����\r$��������mS��;�̘�yxx&�Sl��hω!�L��^���iJ�$O�2\'j��cl	dF�l/��mM��rr�gf�8Fԁ��߯��0Ǝ���8ʒC�-���(tE���,1W��KL�)&,��Wqi�,�.�*3���;Th�ytŏW�i?勛*BMiF�:�T\",+~D�!��]���2i�珍\njK��ܕ�L�O�Θ)\re�E�{J�R8d�Ԋ�1VId��e��.:BD�GUI\n��+�o|ǹ����-�Xp|�~C͈]ҋ�y�Ѝ�/sy�.����m�����E�	kÅY]\Znű	��^5���}	_7�{����E�S�s��^�oϑ���oE�`\'vx�!dT\'�;pػqS=	dɩ��\Zm\'yȂ�Ac����B�HK���Xؕ���6ō��L������;��7X\0*fn�$��Z�\"���\\���~��)�$�T�<7\n���sC\ZJR�/9L���A�EYq��`n��*���2�U�IzJ���=is�P8a����c,z�Sێ�/��4e�Ҥ�L1��EU*/�Wɍ\\E�NOt��s\"|9<ԔC>���$��ĮΝó���G�d��[r��^fB�Ď�iC�<OB�y��0b������D|5��CS��}���x�| ���f���Ac��ڲ���԰��׆�Q.��1gW�֜���`Q-jr�NMu��hk	���%U4�ߡ��e�מ��ٺ\Z�A��\0�4�v��^��OY!ẹ̀N�Ņ�QW�@�:	C�%��)�	6I���R�����v��~�,�^�F�h���������ݐ�X�@��.��{<3&Q�},*�U��%I!��L)��\\1�\\��e��)�\"\Z��Ɖ�G��L�GN�(%�OM�H�LW�&�p�.\\��C��ù�o\Z��6���i\\����S8=At[t�������}�e�}5��_�$v�h.����S$|v�Q���`�;vy���ӊM[��ߞ�}8�ߞ�����]�G;J,>2̄��<9<��9п=���8:�\n�����ds�v��2#;>��L��1�2�^Z�ȳ(ɺ#�$i发�����\rTiEF�$�yb�軒\n�\'Ԋ��&	y�\Z��(W�D�4\ncV��3��E�4Z�xE�+Ս+�����=G�7\ZEC^ʌk����������L�j�t�����N���sNMr�w`���2ő��t[N,�$n�p��\r��烈��B�d;�,t��\\7\"�Y?�3\'�����������?���sq��o\Z������$|�;�۳��{�l�ν�r@_W69��H_;vz���5a\\gC�x;���`FX4ƞ��M���VO>qnMf|�4��f:�\n�)%�z�L�\\\'/ʡ87�+��Q�z�g�x^ES/���*/��S�\r\Z�c�/�F�x��K[xQE]q�EMR[Nuv0���0>��Q ���<8By�	�O��g�`,8GI�E��)-�M�&�Ru2/��ԉ�g�=�ň	�c�i�S��R�N�x��h�#j�7�#L���ʉq�DN�#h�{��r`nG�>J�Q��5��zqse/��F���,�B�HN����3a�qy�Lb7�#z�X�&���\\�:�3s�\Zh���9�=m��n�����l�7��٩5;=���[�e��\03�\r� v�+�c��Җ�1�7�o���b�QN��`{O9�%�B�ŹMэ��H�~=5dӶN�F��H��>���o�sm�b��蠼���E����\0�?��]9�ț��=IX5��z��q�q����^3��+{s�����z�ߌ�Ң^���L�L����Օ�\\��W��ϭo�pw�(R�ͥ��2\nO~Da�jT�6S��0���Te�Q��1-�����_�����T���o�����G좮���D�hՙdvDN��&;8ˑ#K���8��;�sc�\0�|՗��<��؝�s���Պc�-�3܆cKz��Ǘ�\"蓾�̙-#�.\0�߉�Qv�a����{[s�ۆ#:���%�=;���9�vj�w�;0�#G�Yst�A�[�Ӛ����ߡ6bˑa��e����Xб����5MsY+_�����隀m��دX�������qħ\'a=���ڊ���=ȃ��v����m	�e�ű��lOh/���rv�F�p��5!���h�q�w��g�Չ�cO�;)�3Ɏ��z�����Y�A����ʋ�ypfMW���͝���w<O�\'-x�g?E�p7e�Q]��\\Q�]���qf\\]؅�����l����f�ѩ΄-�AВ�\\�8�ۛ�p����̋�96Ďs!���{Y�7�#��8sD�����ҶI�~9���=�����:rz�3���8ܧGZ��W;�Y���9���p��#{{���{�\ru��`[�zw��0\'��1c��9�C���ϖo=�JS+��f�2뷘b�e�#Ҳ�\"�!�K~���l^7t��$�5�X���RS\"C�v��Ӽ���M֘��K��|�d�Z�S+6��gG+��؊����pwSy[�ŭ5�[����4W�3֛���;[��͊�n���qfwwvyv�f�	�Ŵ��82�=�|W\Z�wyAg�>L�,g.�ɵ�=x���6�$z�7�ry�\r1�̉�fN�4kv�b�g{NL�A�t/��u����m��O�����g��sy�\'�[p~�\0vO�$|��˽�[؅�����@�bNOv\"t�%��v x�%A��	l�ooS������\Z_o[6���݄C�-8�mƑ~��h��M��Üo�v`k736���K3�[���)�8vp/{�q��>�ϡC$9|���<p`�$G��r���;�������dd?Đ{��=���;,�l�T�6̷h�r\'K>r�b��L}�+l��5۵f�mk��9m�`�Ek�;���7X��\r>5�\rm��(6���C{��nɾ�V��l��V�w|����8�Ŕ�ݭ��J`/k�z�qn�3�re��l�>�C���w��;\"�[���۴`��)˜M�ؾ%�:����fu���N�N���tgb&ؐ0�\r�f���e�h�Owb�8�� p�7����7��x1љ�!��`M@_K����Hok{[pp��Z���5�;w�kזl�ޞﺙ���	���b�sK>qk�����ӌE�f��n�Ԟ��8��={v�a�fv��Ύ���-l۶UZnٲ��;�K��ڵ��ۿc�������ze>e��1�>o���7���;�y��jI�w~G�w�dt�6��}�1�[����k�6�M�2�ّ�-�b��;�5�>�o3��M�ڼ�4�w�h�3�[1��Mfvx��~�L�߱�΄y��d��+�[�֮-_8�e���:�g�K{v���g����Ǌ�A.����E���\r���;���6��~����}�w��Âm���dǁަ�@[�pg����ܚ�L�z�5ߎt`�dw�����E�������g˶^V|�ݜ-�l��ӆM��Y�݌�<-X�f�\\�̲o��v�p4e�]�[�G�����t3y������!X�z5�~����|��-�H�\n\0�?��{wK̍�:Ņ�HM}�\\��AW�EcБ�$�U�?�ͺ-&�M�N.���`d�^|�t!�7|���S�6�k?�ͦO?d���|�h6-��ı��4n4z�dHoxwgX���ߋ���޻�::Щ};\\ڵ����MZ��7a��[0�oӂ�6m��w,�nǔ�Z�ں��L8�ә�f��Ow6M�ϸ�]֥�-����w�z�z�l���[0ɤK۲s�k���-k�z2�Ֆ�ｍ�o0Ƽ�l��}���j�#_q����m&ۿ�8��1��\r�vx���ޠ�[o�ۼ%C�,�����A�Y>~4�͞�֏W�u�\Z6�]���?g�_��ڵ�Y�1��^���k�䫯Y�a����ݻ�I,\r?ɝ;���Τ��@����6{���VaW��,���iRӒ�i\n3��$��W-l�X������͐>S,�޻IzF\n����歫<Nz���Gdd����.9nͳň�/���[�vI��uqL,���O�s�&�G�z�*V̘Ŕ��׳C=��n���oҳ�;�Ў�vV��b�$/W<�0�`��Iܜlqs���g\'|��դ=�Z����-<��l�6}��O?���k?b��_��l���}���&��|�>�7�����������5�[�%7��d��uMֱۛe�&����;ط�7�R?��	%::�+W.I�����߅�=����7Q��L�7G��@4O�!֛�Tr�^�ovƚG��Լ��3��5_#����b\0����xH�1q�8.�I����@�,F�VP�QR�����!Sdb�Pa��-�m�0� ��\"��C._�ƹ�h�n���k�~�J�;̑�C�[�����\r_��o�߱��A���q:�4qgc��.�idd$�*�E\'أ,D�-DklbQAAO��J,jcă���!���Q/�8�#�Ɋ�e3�������/��[\"�hq���/Oh��I�7-֛\'�\"�\\��\'��8.>W\\\'����b���6?͟��Y����{�$�x��J��b���ez9\n��Q��\Z;��N�O�)R���\n1(өR?A-Ϧ�TKn~&�y�I�%�M��a0ȑ��Q�ʦسX�L<�ZQ|/�P��()�ȤW�	�(�aL3����K������PG�*���$��k3i���/��[����n��kԢ�DN���/һ\n��oZ��\Z\Z�B�:W��^�SBLV^�SJ׈7���~��Xoz-N�g+t�\\�;�ڻ�̞8.ޘ�W�1(�MK�>�\"��X���/�I~yޯ��?!�������R!��D�RH��bPgK �w-�w�7��\rhU �O\"�m���7�H\"^�!k�ыsĹ�׼��/������y�������YȂQ�yBDySz�V��&0tB�i��(��a@�SI�3˛��7Wh�J�kfK/�,F%^���;~b�O��i�?����%��y�����K�s{��c��y������~����5�Mղ�At��~�©�>�\ZC�ߺ�_I�W\0����������3J�Z\0\0\0\0IEND�B`�',0,'2024-12-16 02:44:49','2024-12-16 02:44:49');
/*!40000 ALTER TABLE `menu_items_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_details_tb`
--

DROP TABLE IF EXISTS `order_details_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `order_details_tb` (
  `order_detail_id` int(11) NOT NULL AUTO_INCREMENT,
  `order_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `quantity` int(11) NOT NULL,
  `price_at_time` decimal(10,2) NOT NULL,
  `subtotal` decimal(10,2) NOT NULL,
  `dine_mode` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`order_detail_id`),
  KEY `order_id` (`order_id`),
  KEY `order_details_tb_ibfk_2` (`item_id`),
  CONSTRAINT `order_details_tb_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders_tb` (`order_id`),
  CONSTRAINT `order_details_tb_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `menu_items_tb` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_details_tb`
--

LOCK TABLES `order_details_tb` WRITE;
/*!40000 ALTER TABLE `order_details_tb` DISABLE KEYS */;
INSERT INTO `order_details_tb` VALUES (1,1,1,2,50.00,100.00,'Dine In'),(2,2,1,1,50.00,50.00,'Dine In'),(3,3,1,3,50.00,150.00,'Dine In'),(4,4,1,1,50.00,50.00,'Dine In'),(5,5,1,1,50.00,50.00,'Dine In');
/*!40000 ALTER TABLE `order_details_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders_tb`
--

DROP TABLE IF EXISTS `orders_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders_tb` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `table_id` int(11) DEFAULT NULL,
  `employee_id` int(11) NOT NULL,
  `order_date` datetime DEFAULT current_timestamp(),
  `status` varchar(50) DEFAULT 'Pending',
  `total_price` decimal(10,2) DEFAULT 0.00,
  `orderNo` varchar(50) NOT NULL,
  `date_added` datetime DEFAULT current_timestamp(),
  `date_updated` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`order_id`),
  UNIQUE KEY `orderNo` (`orderNo`),
  KEY `table_id` (`table_id`),
  KEY `orders_tb_ibfk2` (`employee_id`),
  CONSTRAINT `orders_tb_ibfk2` FOREIGN KEY (`employee_id`) REFERENCES `employee_tb` (`employee_id`),
  CONSTRAINT `orders_tb_ibfk_1` FOREIGN KEY (`table_id`) REFERENCES `tables_tb` (`table_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders_tb`
--

LOCK TABLES `orders_tb` WRITE;
/*!40000 ALTER TABLE `orders_tb` DISABLE KEYS */;
INSERT INTO `orders_tb` VALUES (1,1,1,'2024-12-16 03:51:39','Canceled',100.00,'202412001','2024-12-16 03:51:39','2024-12-16 03:51:59'),(2,1,1,'2024-12-16 03:58:54','Canceled',50.00,'202412002','2024-12-16 03:58:54','2024-12-16 04:00:12'),(3,1,2,'2024-12-16 16:14:36','Canceled',150.00,'202412003','2024-12-16 16:14:36','2024-12-16 16:16:03'),(4,1,2,'2024-12-16 16:24:55','Canceled',50.00,'202412004','2024-12-16 16:24:55','2024-12-16 16:25:10'),(5,1,1,'2024-12-16 16:39:03','Canceled',50.00,'202412005','2024-12-16 16:39:03','2024-12-16 19:22:40');
/*!40000 ALTER TABLE `orders_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments_tb`
--

DROP TABLE IF EXISTS `payments_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payments_tb` (
  `payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `order_id` int(11) NOT NULL,
  `amount_paid` decimal(10,2) NOT NULL,
  `payment_method` varchar(50) NOT NULL,
  `payment_date` datetime DEFAULT current_timestamp(),
  PRIMARY KEY (`payment_id`),
  KEY `order_id` (`order_id`),
  CONSTRAINT `payments_tb_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders_tb` (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments_tb`
--

LOCK TABLES `payments_tb` WRITE;
/*!40000 ALTER TABLE `payments_tb` DISABLE KEYS */;
INSERT INTO `payments_tb` VALUES (1,1,150.00,'Cash','2024-12-16 03:04:42'),(2,2,100.00,'Cash','2024-12-16 03:08:57'),(3,3,150.00,'Cash','2024-12-16 03:10:12'),(4,1,100.00,'Cash','2024-12-16 03:51:40'),(5,2,50.00,'Cash','2024-12-16 03:58:54'),(6,3,150.00,'Cash','2024-12-16 16:14:36'),(7,4,50.00,'Cash','2024-12-16 16:24:55'),(8,5,50.00,'Cash','2024-12-16 16:39:03');
/*!40000 ALTER TABLE `payments_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recipe_tb`
--

DROP TABLE IF EXISTS `recipe_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `recipe_tb` (
  `recipe_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_id` int(11) NOT NULL,
  `ingredient_id` int(11) NOT NULL,
  `quantity_required` decimal(10,2) NOT NULL,
  `is_archived` tinyint(1) NOT NULL,
  PRIMARY KEY (`recipe_id`),
  KEY `item_id` (`item_id`),
  KEY `ingredient_id` (`ingredient_id`),
  CONSTRAINT `recipe_tb_ibfk_1` FOREIGN KEY (`item_id`) REFERENCES `menu_items_tb` (`item_id`),
  CONSTRAINT `recipe_tb_ibfk_2` FOREIGN KEY (`ingredient_id`) REFERENCES `ingredients_tb` (`ingredient_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recipe_tb`
--

LOCK TABLES `recipe_tb` WRITE;
/*!40000 ALTER TABLE `recipe_tb` DISABLE KEYS */;
INSERT INTO `recipe_tb` VALUES (1,1,1,5.00,0),(2,1,2,5.00,0);
/*!40000 ALTER TABLE `recipe_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `system_logs`
--

DROP TABLE IF EXISTS `system_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `system_logs` (
  `log_id` int(11) NOT NULL AUTO_INCREMENT,
  `action_module` varchar(50) NOT NULL,
  `action` varchar(50) NOT NULL,
  `item_id` int(11) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `timestamp` datetime DEFAULT current_timestamp(),
  `details` text DEFAULT NULL,
  `employee_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`log_id`),
  KEY `system_logs_ibfk_1` (`employee_id`),
  KEY `system_logs_ibfk_2` (`item_id`),
  CONSTRAINT `system_logs_ibfk_1` FOREIGN KEY (`employee_id`) REFERENCES `employee_tb` (`employee_id`),
  CONSTRAINT `system_logs_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `menu_items_tb` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=124 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `system_logs`
--

LOCK TABLES `system_logs` WRITE;
/*!40000 ALTER TABLE `system_logs` DISABLE KEYS */;
INSERT INTO `system_logs` VALUES (1,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 02:39:22','User admin logged in',1),(2,'Menu Management','Add Menu Item',NULL,NULL,50.00,'2024-12-16 02:40:40','Added menu item:Load Bread',NULL),(3,'Menu Management','Add Menu Item',NULL,NULL,50.00,'2024-12-16 02:40:46','Added menu item:Load Bread',NULL),(4,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 02:44:28','User admin logged in',1),(5,'Menu Management','Add Menu Item',NULL,NULL,50.00,'2024-12-16 02:44:50','Added menu item:Bread',NULL),(6,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 02:44:58','Cashier admin logged out',1),(7,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 02:45:26','Cashier admin logged out',1),(8,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 02:45:37','User admin logged out',1),(9,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 02:47:01','User admin logged in',1),(10,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 02:47:25','Cashier admin logged out',1),(11,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 02:57:02','User admin logged in',1),(12,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 02:57:10','Cashier admin logged out',1),(13,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 02:57:21','User admin logged out',1),(14,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 02:59:29','User admin logged in',1),(15,'Inventory','Save Ingredient',NULL,100,NULL,'2024-12-16 03:00:04','Saved new ingredient: Baking Soda',NULL),(16,'Inventory','Save Ingredient',NULL,100,NULL,'2024-12-16 03:00:19','Saved new ingredient: Wheat',NULL),(17,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:00:47','User admin logged out',1),(18,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:03:38','User admin logged in',1),(19,'Recipe','Add',NULL,NULL,NULL,'2024-12-16 03:04:06','Added new recipe with item: Bread and ingredient: Baking Soda',NULL),(20,'Recipe','Add',NULL,NULL,NULL,'2024-12-16 03:04:10','Added new recipe with item: Bread and ingredient: Wheat',NULL),(21,'Order','Create',NULL,NULL,150.00,'2024-12-16 03:04:42','Order created with Order ID: 1',1),(22,'Order Details','Add',1,3,50.00,'2024-12-16 03:04:42','Item added to order. Item ID: 1',1),(23,'Payment','Create',NULL,NULL,150.00,'2024-12-16 03:04:42','Payment processed for Order ID: 1.',1),(24,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:04:54','Cashier admin logged out',1),(25,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:08:39','User admin logged in',1),(26,'Order','Create',NULL,NULL,100.00,'2024-12-16 03:08:57','Order created with Order ID: 2',1),(27,'Order Details','Add',1,2,50.00,'2024-12-16 03:08:57','Item added to order. Item ID: 1',1),(28,'Payment','Create',NULL,NULL,100.00,'2024-12-16 03:08:57','Payment processed for Order ID: 2.',1),(29,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:09:04','Cashier admin logged out',1),(30,'Order','Create',NULL,NULL,150.00,'2024-12-16 03:10:12','Order created with Order ID: 3',1),(31,'Order Details','Add',1,3,50.00,'2024-12-16 03:10:12','Item added to order. Item ID: 1',1),(32,'Payment','Create',NULL,NULL,150.00,'2024-12-16 03:10:12','Payment processed for Order ID: 3.',1),(33,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:10:20','Cashier admin logged out',1),(34,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:11:31','User admin logged out',1),(35,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:12:20','User admin logged in',1),(36,'Inventory','Edit Ingredient',NULL,100,NULL,'2024-12-16 03:13:05','Edited ingredient: Baking Soda',NULL),(37,'Inventory','Edit Ingredient',NULL,100,NULL,'2024-12-16 03:13:10','Edited ingredient: Wheat',NULL),(38,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:14:40','User admin logged out',1),(39,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:20:02','User admin logged in',1),(40,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:21:15','User admin logged out',1),(41,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:23:48','User admin logged in',1),(42,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:24:16','User admin logged out',1),(43,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:24:52','User admin logged in',1),(44,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:25:04','Cashier admin logged out',1),(45,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:26:28','User admin logged in',1),(46,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:26:43','Cashier admin logged out',1),(47,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:27:07','Cashier admin logged out',1),(48,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:27:12','User admin logged out',1),(49,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:27:51','User admin logged in',1),(50,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:27:57','Cashier admin logged out',1),(51,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:28:21','User admin logged out',1),(52,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:29:47','User admin logged in',1),(53,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:30:12','User admin logged out',1),(54,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:36:15','User admin logged in',1),(55,'Inventory Transactions','Add Transaction',NULL,30,NULL,'2024-12-16 03:36:43','Added transaction for ingredient: Baking Soda',NULL),(56,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:37:39','User admin logged out',1),(57,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:40:36','User admin logged in',1),(58,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:41:05','Cashier admin logged out',1),(59,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 03:41:16','User admin logged out',1),(60,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:51:15','User admin logged in',1),(61,'Order','Create',NULL,NULL,100.00,'2024-12-16 03:51:39','Order created with Order ID: 1',1),(62,'Order Details','Add',1,2,50.00,'2024-12-16 03:51:39','Item added to order. Item ID: 1',1),(63,'Payment','Create',NULL,NULL,100.00,'2024-12-16 03:51:40','Payment processed for Order ID: 1.',1),(64,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:52:07','Cashier admin logged out',1),(65,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:52:55','Cashier admin logged out',1),(66,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 03:58:21','User admin logged in',1),(67,'Order','Create',NULL,NULL,50.00,'2024-12-16 03:58:54','Order created with Order ID: 2',1),(68,'Order Details','Add',1,1,50.00,'2024-12-16 03:58:54','Item added to order. Item ID: 1',1),(69,'Payment','Create',NULL,NULL,50.00,'2024-12-16 03:58:54','Payment processed for Order ID: 2.',1),(70,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 03:59:08','Cashier admin logged out',1),(71,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 04:00:04','User admin logged in',1),(72,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 04:00:45','User admin logged in',1),(73,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 04:00:55','Cashier admin logged out',1),(74,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 04:01:06','Cashier admin logged out',1),(75,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 04:01:17','User admin logged out',1),(76,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 04:04:24','User admin logged in',1),(77,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 04:04:40','User admin logged out',1),(78,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 04:08:47','User admin logged in',1),(79,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 04:09:49','Cashier admin logged out',1),(80,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 04:10:34','User admin logged out',1),(81,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 04:12:12','User admin logged in',1),(82,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 04:12:40','Cashier admin logged out',1),(83,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 04:12:47','Cashier admin logged out',1),(84,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 04:13:09','Cashier admin logged out',1),(85,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 04:13:13','User admin logged out',1),(86,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 15:52:44','User cashier logged in',2),(87,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 15:53:30','Cashier cashier logged out',2),(88,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 15:53:30','User cashier logged out',2),(89,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 15:53:59','User admin logged in',1),(90,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 15:54:27','Cashier admin logged out',1),(91,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 15:54:35','Cashier admin logged out',1),(92,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 15:54:52','User admin logged out',1),(93,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 16:14:19','User cashier logged in',2),(94,'Order','Create',NULL,NULL,150.00,'2024-12-16 16:14:36','Order created with Order ID: 3',2),(95,'Order Details','Add',1,3,50.00,'2024-12-16 16:14:36','Item added to order. Item ID: 1',2),(96,'Payment','Create',NULL,NULL,150.00,'2024-12-16 16:14:36','Payment processed for Order ID: 3.',2),(97,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 16:15:52','User cashier logged in',2),(98,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 16:16:13','Cashier cashier logged out',2),(99,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 16:16:13','User cashier logged out',2),(100,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 16:24:39','User cashier logged in',2),(101,'Order','Create',NULL,NULL,50.00,'2024-12-16 16:24:55','Order created with Order ID: 4',2),(102,'Order Details','Add',1,1,50.00,'2024-12-16 16:24:55','Item added to order. Item ID: 1',2),(103,'Payment','Create',NULL,NULL,50.00,'2024-12-16 16:24:55','Payment processed for Order ID: 4.',2),(104,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 16:25:22','Cashier cashier logged out',2),(105,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 16:25:22','User cashier logged out',2),(106,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 16:25:34','User admin logged in',1),(107,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 16:25:44','Cashier admin logged out',1),(108,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 16:26:26','User admin logged out',1),(109,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 16:38:44','User admin logged in',1),(110,'Order','Create',NULL,NULL,50.00,'2024-12-16 16:39:03','Order created with Order ID: 5',1),(111,'Order Details','Add',1,1,50.00,'2024-12-16 16:39:03','Item added to order. Item ID: 1',1),(112,'Payment','Create',NULL,NULL,50.00,'2024-12-16 16:39:03','Payment processed for Order ID: 5.',1),(113,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 16:39:23','Cashier admin logged out',1),(114,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 16:39:37','User admin logged out',1),(115,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 17:33:27','User admin logged in',1),(116,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 17:36:37','Cashier admin logged out',1),(117,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 17:36:43','User admin logged out',1),(118,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 17:40:04','User admin logged in',1),(119,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 17:52:20','Cashier admin logged out',1),(120,'Authentication','Logout',NULL,NULL,NULL,'2024-12-16 17:52:27','User admin logged out',1),(121,'Authentication','Login',NULL,NULL,NULL,'2024-12-16 19:21:36','User admin logged in',1),(122,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 19:22:47','Cashier admin logged out',1),(123,'POS Session','Logout',NULL,NULL,NULL,'2024-12-16 19:24:43','Cashier admin logged out',1);
/*!40000 ALTER TABLE `system_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tables_tb`
--

DROP TABLE IF EXISTS `tables_tb`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tables_tb` (
  `table_id` int(11) NOT NULL AUTO_INCREMENT,
  `table_number` varchar(12) NOT NULL,
  `is_active` varchar(50) NOT NULL,
  `is_archived` tinyint(1) NOT NULL,
  PRIMARY KEY (`table_id`),
  UNIQUE KEY `table_number` (`table_number`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tables_tb`
--

LOCK TABLES `tables_tb` WRITE;
/*!40000 ALTER TABLE `tables_tb` DISABLE KEYS */;
INSERT INTO `tables_tb` VALUES (1,'202412010001','Active',0),(2,'202412010002','Active',0),(3,'202412010003','Active',0),(4,'202412010004','Active',0),(5,'202412010005','Active',0);
/*!40000 ALTER TABLE `tables_tb` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'posresto_db'
--

--
-- Dumping routines for database 'posresto_db'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-16 19:26:26
