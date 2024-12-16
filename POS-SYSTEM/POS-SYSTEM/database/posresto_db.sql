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
INSERT INTO `menu_items_tb` VALUES (1,'Bread',1,50.00,1,'‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0x\0\0\0C\0\0\0WÙÁ¼\0\0\0sRGB\0®Îé\0\0\0gAMA\0\0±üa\0\0\0	pHYs\0\0Ã\0\0ÃÇo¨d\0\0D³IDATx^í½wXVçšömvšÆJï   `ÅŞ»Ø{Æš˜XR%Fcï‚ˆ‚€ bÇ^QA@zz¥wlIv™yßq/$“7»eö—=³g÷ëXı)ë\\çÕï{µPkäüïjM\Z!jzµ£²IJäê¿(å2%årùk)¦\\^D¹¢\0£ª¹NA±NM±NK±VR£A­Vş…ïı×•¿Üñ¿E4j±T Q+ÑhÈtÅÈt²ŸIÓ¶B£E©Ñ7-µ\Z”\Z5J­¥V!}J’¦uF†V]ügßõ¯,ÿ«\0@jTjÔj*…¶Y(tEY´ò×\"ki´lŠĞB+íĞ$şİÿªò/°J-TlÓR©úÏ3E£V£RªQ*Õ(TJT:JX*1¨ÕèUjt*Z…‚­NZ/3ˆ}EµÅ4…è5hU92Ôz#*•…¢¥ºˆbœ\\\nÕkvÿO)€Ê\"tz\Z­‚bYşŸÿ{¢T*Ğjõèõ:TÊbÔª\"Ú\"JŒ\nä5\n½…NƒºD‡L¯¢X«¤X¡E¯¯  PFkD©Ò S(P*å(‹3©+“S®ÉFYJI‰UI9jÍÿ;ü/°`m3sØ¿<ş÷DØJ¹²IT”¨(SæQ©Ì¢J‘E™2RÅSJäiT¨2$©ÕçR¯L¦,û&•y·É¿ÉíÈ½\\ú†ka[¸°†ó‡–s~ß2b÷~BuáJŠóÑş…ïşW•\"ÀM7ºY„³Ò´¯ITZÙkF‰V-£D™MIÁcnûŒÌÛç¨*Ê L‘C©\"‡U>:u\ZM\Z­\0¾¸ÉSÖ¢Õ¡}­Z\rªl\ZËŠ(-|Lòù Ní\\Ã¾\'²~J/6r–dı\'Öô³àÀìŞ/AØŠ®\\ZïÍåÍƒH^áÚ7¼LÙÏéÔ¤P“t„¼¨Ï¸»gGz½îÊäyèÕùè4yè4¹Ô”5¯*F§j²ÙÍÿ¿Ùhº\nÉ®‹ÿÜ,¿¼o’Ío^—Dü¿&Û¯ÔÊ‘ÿôY¿N~S€ƒşãG¿ş£rÔj\Z½JAQ„^UŒV­<V±şÂEøÆ)Ä®íÇ£Í£‰YØ‹ã“»°k”ÛFØ°u”!K‡µÊ‡#ğ[<Š„í+¸¸y!×¿û€ˆÇ²dÁ‹ûqôı®›çAèBwBç8·¸w¿êÇİ£IóNNà\\\nBR¾ˆÛ»F’ôÙsÑ$l \"ı&òœk”*®Q#»‡1÷:¥Š»( \'há“<ùÜôm¾öv¦8j?	;–¼Æ‡Ø\rsHøz1A‹¦ğ(p\'É§ö‘—LYöuÊ\nîS«ÍA¯É¢¬¤6¹*®\0•¶PzĞ•\Zrµ™ZJ§£H¥¢X)L•–RƒRz˜4š<ä:9zõk²ü:ùMÒÄJªğ@U’W«U«‘éu(…ƒ¢O±…Ú€L]Éï«r¹pøC,ñ¦4a;Y!ó<9€?fFğâáQJ.m£àÔhÏ~CaäçdXÉù]Sx²œ¢ë¹~hº«›(½ù-Ê[©Æ«§§Q^ØÃï3Oc¸võùíd‡,%vİ`ÎnÅãÀeäıšçY!Èo¡,qW¶Œ¢ìF/Õ·xUõˆ—¥é¼,K¥ ı,Ug)ú\nÿ‘lphÏ&ç7Xg×‚³ó;óâò&òÏçúòŞïßˆ‘–œ›îLü,B}L80àmNL´ãÛa¶ì™àNüÓY:œ[S+˜êü‡Tk2Ñ¥Q¦-¤ªLƒBQ İ;…R‹Ba ¤´\nµZ‹^¥âóf†ÿ\ZùnV½Bı`5*J2ôº4J´O(S%S¡J£\\¨de!ºÄœ\\7kû>¢äN8•OÏ!AòU_tI©+¸ÏÍ#Œ¹—)-º‚¡ğò‡ÁŸB›Š6)}R(ù7s÷ÀlÎ,´Çw|[NÎ·ãøl[Î¯õæÊ†a$|ˆæú^çDSš\ZAYöYÊò/Q£MáêXîoÍÎ¡¶Äl¦¦ Ôk¡Ô¨ï£)L 4\'ãÅ-ìğ6á[S¾ğ2ecW6ô4áŞ‘ÑÜÚÇ­­³ù¶Kk¶¹´âäp\'öw{‡ A¦íÓc}MmÏ‰1„ø8ã?Üñ8>Î•©îœy¿7Ç§uæØ¬œ\\6š;»?Áx-CÚu\ZõÅ(‹\nĞ¨´èTjŒJ²ıò¾ÿuùM‰\0±ThÔRâ@!+¢LYˆêÉ-N®EĞÒÎëÁÆş¦œ^1’Èå>dMüònŸîNÁñ/yrô3\ZŸäO\r÷)+Šä…ú,²»8÷İdZHğB/üÇY:ÕĞiœ^Ğ…+úpóó‘œ_;˜»{¦’xxOCVc¸±ãm_şXx–ù—i,L \"û2\rš‡ÔëŸPW’Áó\Z9?ÈcHø¤»»µçäû=Éˆøš²äs%Eñ¬ôu1†®f[÷Vls1a§—¾ìØ×É’›ß,âù“0*£¶p°§-[İ¬9:È£ñõ¶ÆÏÛ†ıfpkO@{YrÈËšÎøÖ¡5\'ztàÌ@¢Ys¼¯)ÇØ2Æ““ÜñhÉşY^\\ô[Ç¿=+•\"ŒìBq}˜öÜ´ThÕÈµ*´š|Ê”yrùêÄ£èø¢½¾Õ¥oÈ_ÅÕ½s¸·i4ç–uáÆ‰û¸\'¡‹;¾¼;A½8¿vÑ\råüWã9·n<·wÎ##x-Eq›ÈŒü‚²{¾œÛ†æÖ!ªSBÑ?‰¢¢ğõê‡T«1ŞA“‹2ùCi zz…zm\n\r%4”fS_‘Ç³ÒL*\"b²»œßc_K¶ô3%ıÈF^Èïğ\\ÿ€åHÙ;—=Û²Ë¡ûûYqÀå]ü»™ræ«Q”¥ îê:õkË!¶õ1çXÏvœ`EH_‚¼m	èmO@üz9°ÇÓÿ~®ls7çh_W6Û¿\'movi‹ßàNîÁf–øõ{;\rÀR\'6MîI:b¥ú¿`­”õ^£ZrJKs¸}~?¥9ÑTÉ©Ì»æ^©Ñ[HİŠşş1ôI±Óã‘=>:õ¿7Ş¤<5šÊ¬8\Zôq4êÏ£Í¥$;‚Ò¬(di(¾LF‚Iç L9ƒ\"õ,%…7Ğå^¥\\~—œGÑ”ËîR§{Ì•ÔªÑXšO6Eö=JO¨Ô¦Q_šÉK}\"arÒÇ†®VìpkÏ×·yôõ]âÆ$~ÌåÆ—#	ğîÀ>‡öø\rqeŸ}B{¹±ÖÅãı¨N¯\"b”-½-91Ğ†cı,86À“Ã=ÙïeEÄ[‚™8ĞœÀÁVDù¸qd€%Ç8ñKKüûZ³Û³!Ãm	aÁvÏwùÎÍŠÀşv„6\'pB|—O§A«ıïSÑ2\nmY*™Œ2Y2OÎl§<%œìû\'P¤] ¢è6eù7xeL¦Q“ˆ,9UÆEj5‰Ôj1ä]\'÷Ñ\Z„­.¸AzÂ!ÊrÎ’uÃUÊi*\n¯Qüğå²Û</I¥N—$Ù`xB…â/*³©-É¤¡<*}:•ºLªtYTê³¨.Éæ™&…u\nUú\\Õë¨)Ë¤^GÆ¾…¬7iÁ^o[¶tiÏ·nosuíHô‰¼,OC{ş[n-íÎO3vÛšÜÇ–Cí8áÓ…˜/FSÿ)†ÓË¸0·3Û:¾E`?[Â‡»r¸›)‘#İñëa.>ÌI’Av„\ru\"r¤Qãºp¸·ûº·—äø`;ô³Ä·‡9ºX<­Xp°‹X¶æ•^„†ÿwú·ä7X®R S©Ñ+\nøQŸJìÖyhïû“›JIÑ\Z\r©§\\ ¬øúü›</M\'>t+÷Âùcm¿¯Î¡Fõ˜+siĞ&óoÕOiTİã•éü{].¥7iÔ§ Í½A¥òÆÂ»¼ªÌF—w“ï+sPçİ¡Tıì1\rù”k3©Ğ\n€³©+/¤Nù„Êò(QåĞX«§±,“FY8·ÖgSûìëeÏz‡wÙêòqË¿…’ÂŠO}J`¿wØïaÆn3õ°`¯G+~=ë;gğ4ärı¦=É‘£Ş–ô¶\"j”;û»´åP×ø÷² °Ÿ5Ál	êoÃQo¸½-~p‡8Jr|°ûº´g[;6voËÁ6ìviÏ*GS\ZHyƒ_Şû¿&¿)À\ZU1…9”ª²IÛÁ}É¼´¢Ä0Ê4Oh(Ë¦J›ŠQşˆ¢ÌkTéÒh4¦ğ²,*e\"5B•êŸòÌ˜Á¿7È(+¼Kiá=*¤ëêK²¨Ğ¦ñ¼<‡k‹h(ÉBWpâô«ÔˆÏ*Ë¦L“Â«:9Ïª\ni¬,æY¥ŒgU\nêËå<Óçğïµ\Z~ßXN•±€?Tf ¸°Ø©®|gŞ‚nÂ²$°oG.~<Šœ³ßòÊpUø\'íñ6»:š°ÏÕœÚ°Ãµ%Qó{s÷à<îšÆ£o†sr˜%1ã<9ÜÍ„c}„ÓdÃÏv„räp·öøõ0áx_+	d®\0]¨àà!Néc%©i±ôëmÉ±¾vìõ4eoköz›³Ëµ=_¹[³oádôÿ‰ŠÖo\n°VVDI¹°a¤w¼Ï÷úË”e]¤®,mÑJTÉèdi¬Ì£±\"mş-Ôy×i(M£F—B­>MîEEªì»Ôè³h,/¤\\—EmYÏjT’\r-S¦ĞPšËóŠ~¨•S­Ë ¾,‡\n]\Z|¡åe­Œ?>×S[’O}y1Ïj4ü©NÃËR5Fß×(ø“á>w7Ç¿kk|=LØêÜ}ö8ènNìGÃyº–?–\\!ßo.{íZ°ÍÆ„íï±Ãî]t3G{ò+7ğäØÎ/îÌ¡®ïHlìÄÙ	İ8èÕ^ù W[|»wàÌXŸØ1ÜYX¨ó€>Öêf‚_OsŠë‡¹²Ó³=Û<Ûò{k¶»™ò¹‹	K:™RilÊ×7gş–ü¦\0W¨U¨K…³õ„ï†»òàĞ\"T¹§¨È½¶à6uú4^”eñ}Uõ%OyY‘Cî	µ†\'4–¦S¥y‚¡(MŞ]tù‰¼¨(¤T‘JCYÕ%Ô•Ë¨¯Tò¢JNCi>/«d¼¨,æUµYæ*µ(òî .LäÇF?>ÓñC½†—µ*Õ*ù¾ZÎór¿^J£>•Æ¬p.,êÃa—Vl0“ÍÎ8ä`Â76o¾¬)!«ø½!–ôm£9Òñm¶ÛXq´·›Íßæ[çV¤î]DØºÁ<ô›Ííûãß½¤’…\röëaFø0	Ü#=›T²`¬`òÉ!’\r\0‹ãM*Ü–°¡ÎDw•¶Ã†¹p°¾½¬ùÎ¥5[İLXïfÂöŞ1*%€yÿÿ’ü¦\0ë\nQ”«)+Ïaïè.(Ïm!--˜Âñ(Ó/Q¯M’lh½6ufUŠDÊ‰Tj“ĞŞ‘Tl…p‚´éü±QM•*g¥Ôê³%UÛP.£V€mÈ£¶¤€†ò\"~lĞò²FECy1?6ªyQSHMI6/jŠ)×dPWZ@•!—çu2\ZËsh¬, ¦,çÆDdW6°¿{[ö9´a½Í{|nßš£®æDŒv!buî^Dyê^®~èÎIìqp’Tç»vìêlFÒîÜ<2›$ÿy\\YØSí`/±w_ç6’Šêo\'-£Ç¸KêY€+ÖÅRØä.ïH,j\\\\9Ò\rßî¦ìpo…ï\0[w3g§[¶x˜²µ«»»Ù ÏN“\0ş5 ÿ¦\0«åä*Š¨Ğesxš†;©-ÈsmŠä`•Ëîó¼ä)õº\'T*©Ó&óªºrU*eÊ\'¼¬*”Ôm1‹j}\ZeòD*UIT(“xUUÈóò|I•ÓXVÌ‹JÏË\nxQQÀ÷uÅü¾QEuI.x¡§B—EC¥Œ?¾(áy’2}:µÚ§4”åS]™ÏUÉZÁwÙi×†íæ¬mÿ6[í[:ÁÃsœIXÀãSèÛšØÁ.p·aOç¶t3áÛ®íIúÅ•/¸·u4ıÚ3Ü•#=Í`Ç©Îö³\"~’\'şŞ¦œjCìdwB‡Xsj”#!ƒl9ÒÓ‚ ¾vøzš:Ğ‰€^Vœ›ÜosöumÇ!aÃ»Yr »\r›œÛ±³›­”I“e¦Hêù¿\\Eët\"U©¡º0…£ó]©JöEu‰²\\á¥R¦xD‰,EÖu)Ù öÕè3©3æòªº˜y2•šTôE‰d¨Ò>$ãa4FÙ]Jd÷›Î×=¥JIcIn­>çåÙTk“)S¥ğûçFÊu9’Jo¨”S_!ãûF-Ïj‹yU^ÈË\n/„ƒ&¿ÌõõƒÙßµ-»œÚáßÙ‰uíŞásë·ˆz¿/‹;óäÈ4.Ì÷äñÂ¡œ\ZìÌ~Ï’g|°K[2ö.#éä*”W>ãşÆA\\˜ìNØ\0{ûY2Ø†øI]8ŞÏ„Ø	.„5\'r‚±S96¸-q“\\9Ò«==Ûs¸‹	‡<Ú³Çµ%Áıí8=Ö“Ã8Ø£{[±Ö¢[:µc——»½lÙÙÅ–Â§É¿º)â7X¨ŒR½šÌ‹¡ÜØ1ãã êŒ)4ªSı:ƒ$ÀPåÜäûê|i»±4‹re2õÆtªµi<+Ë¡Ş˜)mË2/S£OæY™¨İ¦Q­M¥ÎAcIõ†\\ªÔÜ\\éÜ—•¹|_¯âyŠ\Zõ°/jÕ¼ª×ÒX%ç/µ¼ª”IòÒ˜BåƒãœïSz˜Ü£LßeIë\\ûÂ‡Ä}Ó¸¿sac¬ğëÒ’°Aø÷¶Î\ZdÉõ\rSÉ9»¢ókHŞ:’sS\\	bÃÙ‰n„°áâtwÂGX=ÎK3İ	gÅÅ=9;½#§}ì¹9ß[²Ç¾^89Ğ¶„¶e»ë›µf§çÛø\r°f_O3¶wi\'¼ÍÃŒMNmÉ|t÷W©g!¿)ÀÅÊ\"êõ2.îX‰üÜn*ó/ñ^(¨W6,€(W>¦±´	À:ÃS\nR/ Ê¹Jµ6‰Rù*TI”?¤¤8}Ñm—gJàVª“ù}yÆ-ªÔiTkÒi0æP\"Ÿ-Šø)å©Ô”J >«Vò²N#1ùÇgzWRmÌçYy>ÿn|@~ÀJ‚ú™ÔÛßÎfx:ğYÛ7ØÛ×–[ßLæşşi$|ÑŸïw—¼ìƒl89Ü‘ˆ¡ö„MpD½øİ3¨IÜÁuı¹ú¾§ÄÔ«ó»:ÂŒ˜IœŸîL¤·—t#a¡\'çg»pkI7\"F[?Ù• ş–óÉ\'.ÍèJä÷nMÈHK5Á°\'F;±Ã«5±Óz³Îş¾umKzâ­ÿ\\¬’SSüˆ#sºQpq?ÕÚG”ÈïP’[VxÉBÍ\n€ÿÔ(—ÔµÈ`ÕjïSV|‹rÙ=^–fòÌÎ¿ÕË¨T\'I\0°¡$‡Z]õ†)ŒªP%K±ïsaS5BeçñªF)©h¡šëÊ‹%6‹m¿ªÈ§®JMCE’ÇsÿËaøunÃÙÑìïÔ†£]mÙ`õ.ã=¸ñíDšÊùå^ñ~—c=;2Ä–ØÉD±$bvGÊ¯ïâNğ\nŒ×¿áúç½Hşl §ÆÙ=Ñ‘ÈñvDŒ³âÜLÎNwäÒ\\Wâg97Ã¤5}‰ŸfOähkb|\\8;±a#¬‰cÃÙi®$¼ß•S“l¹º¸A£¬‰˜àÌáş¦±\'`°#Û:·áéƒ¿Êş\nùmÖ*iÈKàôROJ’Â(/y‚2÷¥…·%f\n6\n Kå%ĞSNSZ|EFÅ©q¼*ËD›}Cşİ¦¢@I–dg[Uêä™W¥°ªRı„—Â®K¶µ®¤@b°PÑÜÆ*UÆ|^Õªø¾4—Ê\n55™|_Æ¹ÜØæĞŠˆAÙïÚ’Cî¦ìélÊ••#IÜ?“´À¹œšî@œ\'úšá/ìéäNœèÛ†{ßŒ@wí;ŠoìByaWÖvçÁšŞÄLsæäh;ÎÍêLì4W®/îAğHSb¦9r~®á>¸±Ä³Sm‰gËù©îÄLtä´	¼kNÌLGÂ\'ZHË±Vœô±ãô7±âø0{¶{¶\"ıaƒåŠÂ?Ãà—ò›\\¨-¦6ıé{\' z„N›È‹ê$”™—$+Ø+)\0*Z0¹¤(yz4µÚ{4èQ)€1ÿ.uÚT^Tä4©vC&/+òù±F!ÙPñ9ÏÊ²${üª²ˆÆ’\\©ĞX^$1W¨æ†ÊbÉö~ß “B¬?UQ_käY]6Ú››¸´ÔÍv­‰æÆa÷6ìrjÉÁ^VÄ.À•­c¹»o\"amhÂÙqÎ„väÒlOüº¾Iâ®	$ü”˜¯PŸ_GÄ<n¬ğ\"fªã¹4¯¡£­95Á‹ó:7Ã™[Ë»;Ã†¸V\\™ïB”%WætáÜ4g\"Æ˜qw¹7Á#ÛqaA\'¢¦Y6ÉŒSSğÔ–³³»æãDğH{õ7§L]ˆL.Ú—ş‹U´LSHAØNî,Ä\Z6ç\ZÏ*’©2¦H \nF\nĞ8ÂÙ \nnQ£yÌ³‘É \\öZMŠ°¾ğÆâ{’‡,Ë¸\"%E„M~U©àu\ZIe‹Œ—xÄş2eÏ«eüĞ âa9ueù<«*¦¶4—ki(7ğª:GªØìêøÁı:âÛÙ„Ív¿Ã¢3\'Vö&ùØBîlËÙiNœlJ¼áCìˆí@à03Yúî>d	[©¹´…ø]ˆ›Ñ‘Kóİˆ™bGô$\"Ç[rnfG.ÍíDÀ –\\™ïÉåùDO±%nvG\"¦Xrf–÷Vv#|œ	ggº0Ô„˜Y®ÜZÙ˜¹ÄÍëÊ^ïvDMv%`xk‚Ç[±o€¥ê¿ÏÜfùMÖèˆZ5™‚›ùÑ˜„!ï&²ôXÊµÉ¯miÊëP\'UZ W«ñ²<ƒJe\"õ¢s‹\ZõI\ZDÌlL“’!ÊìkÔê…ŠO‘Ô´\Zm&¥ò&§M{KªñşØ¨¡¶4ï\'›ÖU<¯•ñ²JË3Y	ë{9Ö‰}nm	èaÍñ6l´yƒ3Kúqê‹A<9:Ÿ[ÆrÿÃ„0çÊô.íİšÀ¡&ÜXŞ›Dß¥Ü\nZAî¹õdù/æÆG}	cJìt\"Æ™KÀ^[Ø…#ÚI68~†‘ãm¹÷aoÂ}Ì%€ï¯éCì®/ñ r‚9á>–DMvàÂû¹ùQ‚ÇwàÒâlIè8{NMµÁwD¶÷µøoX™ÆÉ%Ã©Î\nG_p‡ZÕC*d	g]“Ø+ì°ˆ…Å$Šî“Ÿ|–Òâ»hr®Q§{‚&û&ÏK2y.Ê{¯™.q]SZ\0›AIq’ä`‹¢Í¿ÇËÊ|)I\"Ü¬Q™*m¿ªSğÇF\r†låŸ$~•\'ÁmğïiÁ‰ş÷±cGç–Ä|8€Ûf‘ä;‹kŸõåş‡İÚ†ó“:rjŒ5A£LÉüv<²¸\\9²ˆô3Ÿ\"?ù1ñïwæüg¢&[soE/ÎL¶•\0kFìT{î.ïI´ğªg»rn¶³d_ï­îÍé¶DN²X.óİ9=İË‹;;×‰““m	ãHÀ03B&Xrd¬%»Ùı×,ZID£z•.•ãsºQUtêò|^\ZRhP$ -| ©ãfÛÛ¬®xUª‡Ôj“¤šJåC\ZôO%ö¾(Í¡Bõ„WU’-â]as+Õ‚ÅéR¼Ü([#—\0vø¹È]«ŸJñp™&]ZÈË\Z™tşéhooæŞºìóhËÉañínÂa/BÆº¶¤\'÷}g‘´ˆØ…x°¢+[5ÆšÛKzã7´-÷×\r%%è#F|BRø‡èN¯åÌœÄÏv$dt{î,ëAÜ4IM&öŞÿĞ›‘fDO¶çìL\'B}Ì¸ô;	K»H*ûÜLñpX=Í†¨évDÏtàÜ|7\"¦Ø;Ë“ÀQV÷1Ã‚=Ÿvió_°È¦Œ\ZÉ£Óå%·reÊë(Õ9¼Ò§ğBqj}¦j³İd3³%¿ªÈ”À5Ş–\0¶·¬X¤1ŸR­ño*…i	ŠJàÖ…W-Ôö#)ñQo +iŞrµœ\n]&x®“@ş9À¨)âeÉ<½ˆ¨9øyY6Ê‰6-89Ø‘øy½ˆût0Wvúp{Ë(NÏt v’H+Z5Æ»+0Æ‚ä­I\\Nö…\räœûMÔ*ÎÌq$ù³şœôéÀõE$,ğ\0N\\Ù‡¨	V\\çÆí¥ŞDM´‘,TôOzqMo‚F´çÊ|bgØqa¾³ÄìğI6ÄÌr&d¼\'ÆÚ>É€q¦Lsfµg;JÔ¿~PÀÿo€›G è\rjÎØ@qÀ2Œê;”×•R[t—šì8©\"$l¤°½Í±pSf*…2Ù=‰ÅRœî‰T®R&Ñ Ï V\'ª\"i)D°T„EÂÛ\\/ÎU?¥±$Ÿï«<++”«†Š¦åÏş¡\"—WÚkÜØ7” qí9ÖÍ‘¶ìr{‹°!ÄÎëÉ©•Ş<>6ŒÃ3ñÚŠ¨±–\\šÑ™°ávDNrãğsîEføj®_ÈU¿™è¢×9Ãk‹=ˆj-©d¡yO¶™Í1Sœ8=ÉøY¹÷IÎÌ²—ÀLXØ•3“ˆŸí@Ül–v&jš#AcÌ93Ëq¶œšÚSö³å«¾6ÿ|€::¥ƒJF‘*µ®Œry\nQçQ›Í3İ=®Æì\'û~úœxŒ…	”+nS”Gîã	P¡†_–åR_’Jµî‘T.S<@_xï§‡¡VÿTbmCI&OïŸ‘â^¡–E;(	VhÓi,+ Q„JBD<\\§âE­²	Øª\"©^ÜXOEi*ÙÇ™jÇQmÇ‰AöìviIà0{‚fwæÜÆ…­àÎ×CˆœbEøHSî-íMÄ¢FÛàcÅ£Ãsxzj\rù	›(¾ºYØrbæ;?ß†kË<H\\ÕØ™œŸß‰S“­IşlÄÚ°1¦\\Yà.­_]âEğ8ÎÌr$aqWÎÎqáÒ%GJ„fŞ÷$~^g¢fÚsr¢\'ÇwÄ¸	¾Şmør\\/tÿì‚¿\0X//‘\0VåÈä\Z´éWxpúK^îQ¯ºMyş\rª•÷I¿{’jÕmjµ¨Õ\n¦&ÑhLE›{Zm2†â;è‹nR®J¤\\™(å”…n²³\"Ö}*±½)Wİä…×•æJ¶V8Pª‚‡c ¢‚ô¬Z.ü²V!,Â¨Æò\\\Zk3)8·†33]	êÀş®¿#x û<Úql„=Q+ú³n0¹Á‹HÜ0””/I\0Ÿ.²MœÔÓsİI:¶ÔˆÕdœÿŠüK_¡9³Šs‹]¸²¤#Öô\"dœ©ìİ{KÎTÂbO.,pãHÿw¸½¬‡JÅÏuáîª>ÄÌv’€`‹õó:sbœ%1³:qr¼-‘3ì‰šnMà({NL°Ã¯Ç»¬×ûŸß²#ÆÈhTz´b´»N†Q]ÈßOÑ¦“÷ \\j˜{&¨N’Â Jå•¤K\"¶…7©Ó?¤Ru—Æ2QQJF‘•Ğ”º”ÀÌ”,QĞÜ•€xsxU[’C¹6CQ4Ô5Ç»Ï_ƒ+’êÂG?üL8hº{äŸùˆIRËLà ÑVc…o3âö!b™7ÉGê7‹\'[Fñpuâ&;:Êœksºpz”51ï{’´˜”ğUÜú€´3Ÿ :ı1§çØH\0Ÿ[àÈåİ	Ÿh)1X\0)À¾òANùXpi^\'®¼ïAì¬&`ÏÎs‘X{nA\'.,tçÒ\"/	àˆÉDOs&ØÇŒÓ3lğY¬±¶D²cëãÿùMwbÌQÓ\0k:œZ]\Z§ö/¥¦à†œ+h2(Hºˆ1ÿ¾ŒÏêÒ©R&S-*KêDIe×éïSœ!²\\ÑŞE_xŸjp®J)ÊfÆ6U2Áàš’\\êË$p“…S%z°ÀU2)Lúşµ÷üª2WšdÍãp¿Vö·åô„øö0%txGNÍîŠÿ|7â6\r%Åw:×Öô”œ¦3]9>¬=¦»rÆÇŸ!\\ / ùÌ\ZRÏ|LÕ•õ\\YáÁ£Ï{:¾IŸ–\0ŒšjËıU}%Ÿã,yÔg¦Ø’´v ´-{ke/Ç´\'vH|X7§‘S91ÎJ*S†M´&l’9ÁcñeEÌ¤NÜ	;øÏX4}‰)ŠtF4²BêåWy³²ìxOãyfHÅXp2Ù#IÅV¨a(¸M&‰:]²Ô¯\\©¼Ë³’d^TfJ,^õ«ÊBêôYRCäîŒ5;gRŠó5°Âc@\n€›‹k’šûEY\0ü²<›ÎrccNŒ´Ä¯§¥”RÜçÙŠ¸İ‰[Ú‡Ä³HØíCnÈÎ-ëÄé)æÜ^Ö“ÓS¸ºÀ‹cı[szaîÇÃà¨ïï\"#n\rÕ	$€Ÿn@äTs	ÜëËºI¡X`nßTE,ï&›d)|r¢E“-^êEäTn~Ø‡kü‡t jš“ô\0œšêÅVÒğ—¢ûg\ZAòkä¸DYD‘¡€})ÕzÙ	;‘ßßƒ!3eÆYªU÷¥´£H-VhcTÜ¢Şğ˜Fc2Uª”Ëïócu./Ê2©3¤IéK‘‘ª7d¡ËDƒ1mŞ	\\ñ€4«faŸƒ…Š \nµÜì-\'«¦4ORÏd±ı¢²PRÑ\rú4Ô—wqıËœöqàPwsNù8±ßë=¢§y½¸\'|çpçÈtRı§s}Mw?éÁİŞ’77­#ƒÚqeõ\0	àÌèÏÉ¾´”è•”œûœØ÷¹¶Ü•„¥nDO·—ìnÄ$+Éßş¨W“šïÎ•R,ö	Æ\n-Ø{ÂÇ”‹‹<$ï9n›¤¢£¦8szš3ÇGu tbgv5#x¬y÷ÀÉ_“`µª\0¥>¹ÖHyQQ›ÇR—‚üéYò“#©Ö<Úaë)èŠoQ¡}@©ì:Ê¬sT(oKÍê\"5))¡ÆŸ—gIÉ^h©Õ‹â‚èÖH–¼ëzc*•šÇÈ3¯Q­}Š2÷eê4êJ…}-”ı¢ZF¥!‡ú\nawó¥ëëKr¤Şçõ=g>ÇoÂ{\\šã…_/¢|\\ğíÕÈYÄ¬ìKè\'İI<2{»Fr~YGâçØrq±3;5Ş†«»½¼7ÍàÊŞY\\ñ›KjôÇD,\'jßwàş\'=	õ1\'b’5ßïÂ™97Ïã#Û0ô=n,íFìGÎÍï$Ù]aï®ê+-€–<é)\"ÉÑ…£ÃL¥J’P×~£¬	ŸáÆÖÈ\'üóVêdèµùhŠ²¹¶¬ĞÕ”§œD–u™^@•ò¾ä-W¨’ó$J]’äP=/K¡\\~‡2ù-É—ÊnIaÑ«ª\\©óCWxƒ\nõCI\r¿¨ÈBO¥VtKŞÁP|‹¹”§ğ²¢}ÁC).q²h¯}Q^@cµœJC6/ô©ÔkS©Ç«³y.¿HÎÑéøût j¼#~=ÚJõİ€æœYÚ›ø/†p~ãPœDÊ±\\ûØË‹8=Õ†+zqjŒ·?éËµM#I<>Ÿ‹;§KÕ¤¤ˆdD,ãìÇ]IXäÆåy®\\ùÀ‹°ñ6\\˜ß…ÓS;:Î–ó½$•,{my7NÏ°çÊÏ&/z‘Xv$jº\r—{HIÈ©Ne…ß3¢§»sxlNúX³½—5ÕÅOÿù\0ëµ*¥FêtOÙ8£Ê‡(É¸DµâÚœËÀ¯*Ò)‘ßçEU6Uºd©bT.@•òÆ§’³URÔTó­Ò41µ\\uEv‚”¥j¹Ly‡jıªõ÷Ñˆ>®L)¡Q¡L£T–Ì³Ò¼×‰\\)RnÈ¥ÜÍ«2Q;N§®¢ˆgåéÔæÇqp2~#L96È”c}ÍlCğh[|\'9¶¢qësåÛ¡$ï\ZÍÍU^dmBÄDK}Ô¨qVDLuàì§ıy\Z±œëûç’nÙñŸQ·šØ•Ü^Ñ•¸©¶$1Œ3Ó‰˜hÇEQãoOÄD‰­‚©\"<ª¸¹Î’ZNÕ¹ùîÀñó]ˆá$±7x¬G‡[9Å•Cc:<Ö’ıC\\ù±\\Lõç˜ü5ù‡\06ªTÒğPcúâ6\r¤\"÷<%ùiT>â‡Ê§h²¯P£y(µáÔ•¤Q¡I’Š¯Ês1<@—{—¥ÙR¶J„D’zÖ<¢Î˜L‰\\ryY™G•&‰ZÃc•§ğàêq‰Á†Â$	Ğü\'	k™·%p¨–Q_%ç‡giÿ÷ujjÊ\nù}ui!(.äØ(3voEÄH\'ônOÈ$\'‚çw&æËÁd…,åÉ‘ÙÜÚ0˜;ŸôàÁÊ„Œ5%r¬%18>ÚœøÏ¿m,	{f‘¹ŠÇáËÉ<µœGÛÇğtİ¢\'YqñıÎ\\[Ò“ QfÄÎì$0Ì„øynDMs aI7	D±~ù/‚ÆXpzº“ÄhÁì[õåè03GÙrr\\G|™r|š¾CÚ²k°+?T‰Ñ…É_“`B‰A‘GÌ9(ÄÀ«ìKè“)Ë»‰&û†üëd?<Mş	šÇTëSx.bWY/Ëò©Ó¦óÌ˜Í‹Ò\\)Şn,{*M—ĞÔd\'ªH¹R3^!•†R1l%U²Ñ‚µÌ{®“<n¦¨*‰u‘ğx^UÌË²êJòyY+çãCòÏ®\'t’=!£mñ÷î@ìÄ.ìïÛ–ĞYğŸïÂ©OûI£RÌåÁ¦‘R®øÊ\\7©uæÄĞ\\ŸßUz8âÖ nËXIE§D|Lò©‘ŸÿŒ‡ß–\0>7Ãà1¦$|Ğ˜.DMqâü<Áb;Éyº´¨«äŸë.möFÏp!|’T&Œ˜lÛ´=Ñ™ı}Ú6ÎY*l‡ïS6÷s L•ûgxü-ù‡\0VèÔÔÜáÄªa”Ü¤øQ4¥<+}J¥âuÚGhs¯ò¢\"“Re¢¤¢óŸ—j½\"Ïü}E®Tl4¤ó‡z¹tí“;áRÒ£(ı\"¯ªò¨3dQ­iª8‰,—ˆ—³Eå¨R•&-Ğ\"œ°äTŸòÂ  ¦0‹ÊDÒƒ9Ù…˜‰îDw&ÚÇ\ro4Û• ¥}äÅíƒÓHÜ?ëŸ\r\"~¦«Td¸¼°+AƒÛsnj\'Fš¾¬Ákûó `)qÛ\'ğôÌ*\nbW‘~`\na>x\"€Ù.’½¼µ¢Ç†›>ÁS“œ›ØrÔ´’ã;Û­ißìÎÒúéé‰íŠÿPNOó`wÏ6³Ãw Ç¦9â7Ú’¯¼mĞ«rş¿%ÿ\0À\nŠZ2£·’sâtÏQ›ƒ:í}ò3.R\'z™ïâeyºT¨e@m’”ÍC<EqA”…4\Z›«KO¤ñI†âÛ<¯È2Z°ï«ä”ÊS£O¡±,\nuR“3õÚ¹jfğ3Ñx§m*CÖªò\\—,-ÄpÔŠb¸öÍ`NŒ°%f‚ûÜ[9Î/:µàÄ|w-ñ ş›á\\İ3‘Ìã‹¸ıÕpNOr r¤7–zãëı.QãğbBôÇı8óÍb¿ÀµÃs¹0³IÚåCìL;ÎÏtâÂ|G˜Jö÷¤-‡û·áô\r|È)ÄÏíÌ±‘¦R¬{r‚-£¬9?¿+#:?Ïƒc#Ì96Ü¦	ØÁ6„ïÄîí	™æÂ‘¨ä™“¿.àŸ¦òkÚVi„íÕSR¢åøG‘ŸİDYÑ-êT·©PŞ¢ÜNcI¿¯+”âWá\rµÚP’N¹âÕš»ü[c.E©ñÒÏZí©`/\núÂ’Zş}LÊbUiÒy^)çU­’úR‘Ø( Q8M•2©¨ ÏªŠxYS,Gz^“G]éS—eI–ÕåYTï€6–Ô½ğïm\"ÙŞƒ=Û>¡»Dªr¦;±k‡ûÍ(-$ùĞ,®­ôæòÂÎê@Ô¤Nœ™è†ÿ@¢çwåÌÚş_İ“ÄãK¹´m*)¡Ë¹î7Û{\'qtLbÆÛq~º»Ô×0À’H†X<ÊĞQ–nÇ…9’g½Çû]ÉŠ˜\"Rœ]	cEä´NeËŞ­ñfÅşm	ä‚ÿ°öŒµáĞÂÑhÄŒ;¿«YşÀb2Ï&iš6@L®¢¢ª(‘£‹»Q›Œ<ç&•Ê{üPù„\n]²”•\"’‚‰ÂK.W>’B\"1`[xÏ¥E÷¨V%KW…:•j1:¡²€†²^T‰êO.u%9ÔˆNJCUú¦äF½(–‹1IÒ±ÆŠª\ré<¯Î§NÄ»åbfœl©Å¶ÂJµá&?œàÚ—}86ÀŒóÓ<¥›|¤\rGÆÙ4¯gV\"xUo®ìÌı	hÅå÷=kF°h`ŸİC}Û»¨±Ÿ\r$âëÁø®èÁåmS¹ã;—Ì˜yxx&¡SlˆhÏ‰!ÄLêÌ^¯¶èiJÔ$O2\'j¼ácl	dFül/ö÷mMØ¹rr¢gf¹8FÔ½Øß¯‡š0Æ½ıÛ8Ê’CÃ-Ùÿş(tE¢Øÿ,1Wš¸KLğ)&,“£WqiÛ,û.¤*3–âÜ;Th’ytÅWåi?å‹›*BMiF²:ë†T\",+~D£!ƒ½]ŸÁµ2iÈç\njK³¥Ü•¢L¨O§Î˜)\reã‚Eè£{J™R8dùÔŠö1VIdª¸eé’Ç.:BDçGUI\nµº+èo|Ç¹Ùİõ-‡Xp|ˆ~CÍˆ]Ò‹ yîĞÈ/sy×.¯ÂÑám‰ŸéÄåE	kÃ…Y]\ZnÅ±	öœ^5€ÀÕ}	_7œ{‡Şçá±EƒSæsõ£^œoÏ‘ŞíèoEĞ`\'vx´!dT\'‡;pØ»qS=	dÉ©‰\Zm\'yÈ‚½Ac­‰œæBÀHK¢¦‰XØ•İŞï6Å½ıLéÀ¾¡Öì˜;µì7X\0*fnó$ëõZê\"ª´œ\\æáæ~´¤)Š$ªT‰<7\n¸©sC\ZJR/9L¢ÿ¹AŸEYq’°`n½î©*ÕŸò¼2‹UÂIzJ™êÙ=is™P8aÂÙã‡Åc,züSÛØ/†¶4e¼Ò¤L1¸íEU*/ŒWÉ\\EÄNOtáøs\"|9<Ô”C>ÖÌí$µéÄ®ÎÃ³¸·ÕGòd£Æ[r÷Ã^fBôÄœiCÔ<OB—yöå0b¾õáâÖÉD|5˜„CS¸¶}‘³œx´| º¾Çf§·¤AcÛÜÚ²¯§¹Ô°îß×†°Q.øö1gW÷ÖœŸçß`Q-jràNMuæøhk	àĞñ%U4Æß¡ìéeÆ×­‰Ùº\Z£AóÛ\0Ü4¡v±Ä^¹˜OY!Ã¨Ì£N“Å…¯QW”@•:	CÖ%ÊÕ)Ô	6IÍèÉR¢¢¹ïê§vÙÒ~¨, ^—Fµh¾“œ­Çèó¨İÄX@ú.µê{<3&Q¥},*ÊU©Ö%I!ÔóŠL)ñ³ø\\1€\\ÄĞeÊ’)£\"\Z¥ñÆ‰ÔG“¼LÊGNî(%ğOMîHÄLWü&Úpâƒ.\\ÛàCÜ×Ã¹¹o\Z™ç6ÁŠøi\\ıÀƒÓS8=At[tæÆê„¯èÇ}ÿe„}5ŒÓ_$vóh.˜ÄİıS$|v¢Q£İÙ`û;vy˜²ÇÓŠM[â×ß£}8ÚßÀÁùÆõ]‚G;J,>2Ì„³ó<9<¸¡9Ğ¿=£í8:Ü\nßÁœğñdsçv¬ó2#;>øõL‚¿1À2­^Z–È³(Éº#õ$iå‘çÜá•ì²\rTiEF²$‚yb¿è»’\nê\'ÔŠŠ&	yú\ZŒ(WÜDõ4\ncVÆì3”åEÿ4ZšxE›+Õ+÷¤¤‰˜=G¬7\ZEC^ÊŒk”‰ˆ¯›ö—¦òL„j†têàò‹ÔÉN“´˜sNMrÄw`¢§»2Å‘ï†´âÀt[N,ò$nİp¢×\ræÊçƒˆŸåBÜd;®,tãü\\7\"ÆY?«3\'§»º´÷äøªşÜŞ?Ó†sqßÎo\Z†ÿèö„µ$|¸;İÛ³·‹{½løÎ½ƒr@_W69´äH_;vzµÁˆ5a\\gCÈx;‰ÅÂ`FX4ÆƒıMñêÊVO>qnMf|ˆ4ïåf:ã¿\n°)%özòLÑ\\\'/Ê¡87•+û¦Q’zŒgòx^ES/‹ç¥ñ*/´øSù\r\ZŠc¨/ŠFxˆŒK[xQE]qÕEMR[Nuv0†‡‡0>ğ§üQ ò›ûÑ<8Byú	ÔOüÑg†`,8GIŞE´ç)-¸M¥&™Ru2/©Ô‰´gÑ=êÅˆ	ÕcÉi«S¦ğR—NxòâhÈ#j…7ş#LˆœáÊ‰qæDN±#h‚{ÇÚr`nG¢>JìºQÜİ5‰ó«zqse/©µF”õ®,éBäHN°Å’3a«qyïLb7Œ#zÓXÍ&ü›¡\\İ:†3sİ\ZhŸ—9ş=mñínËáöìélÉ7­ØÙ©5;=ÚñÃ[êeï\03\r· v¦+ÁcÌñÒ– 1–7Ão°©Äb¿QNìò¶`{O9µ%ıBÅÅ¹MÑ˜ÑH«~=5dÓ¶N§F¯×HûÅ>¹¢øoüsm±b¨„è ¼°‚˜E½¸öÁ\0â?Äñ]9³È›¸¹=IX5‚Óz³°q»q÷ÓáÜ^3˜«+{såãŞÜÿzÉßŒçÒ¢^ÄÏìLÌL®¯ìÃÕ•Ş\\ø¨W¿èÏ­o†pwÇ(RÍ¥àä2\nO~DaØjTç6Sõà0•©ÁTe„Q1-œº¢óÔ_¦²èÚì³TÊÏóo†ËÔÜİGì¢®œîD´hÕ™dÂ™vDN÷&;8Ë‘#K¼ˆß8ŠÛ;Çscã\0î|Õ—„<¹´ØósºàïÕŠc½-Ø3Ü†cKz°¼Ç—ö\"è“¾¯Ì™-#¹.\0ß‰ĞQvîa†Ÿ·‡{[sÈÛ†#:²·‡%»=;°§«9ßvjÇw;0¬#G†Yst„AÂ[îÓšã£Øßßß¡6bË‘aìíeÉ×îíXĞ±úÔû”5MsY+_‡±¯Öéš€m¼ùØ¯Xˆè Ôê”ÔÈïqÄ§\'a=¬ğíÚŠ½½Û=Èƒğîvìïô¾m	ìeÎÅ±‰lOh/¢û™rv¨F»pªŸ5!í÷hÏq÷w‰êgÁÕ‰îœcOÌ;)‹3Éû«zğà“îÜYâAÊı¸³Ê‹«ypfMWâ¾êÍÍ£¹»w<Oß\'-xÙg?Eıp7e©Q]şŠ\\Qã]êÅùqf\\]Ø…³³­ˆšlÁ‰ñìfËÑ©Î„-ëAĞ’Î\\Û8Û›úpçëÜüÌ‹¨96Äs!¼—Ç{Yâ7ª#û§8sD”ÿ–ôàÒ¶I„~9€ÃË=ˆı´‘ó:rzŠ3şıÌ8Ü§GZ²§W;üY³¯9‡úØp¨·#{{Øñµã{ø\ruáĞ`[özwàØ0\'öõ1c—·9¾CœØÓÏ–o=ÛJS+íêfÊ2ë·˜bßeÚ#Ò²\"“!—K~ÑÏÁl^7t””$À5ÀX¡¦ÅRS\"C‘v•½Ó¼ùÚåMÖ˜¶àKû¶|ádÂ‚÷Zğ™S+6¸·gG+¾îØŠ¯ìßæpwSy[²Å­5[²»‹©4Wã3Ö›¼Ç¶;[²ÛÍŠn–øõqfwwvyvf	¤Å´Âãœ82è=|W\ZµwyAg’>Lü,g.àÉµ•=xòÍÒ6$zª7ç»ry²\r1ãÌ‰fNØ4kv²bg{NLëAèt/¢æuåÂòî¤mÎíOºğè³îñgÇÙsy´\'ú[p~Å\0vO´$|™¡Ë½ñ[Ø…€»²ªç¿@ÌbNOv\"t%Çûv x %Aƒ¬	l‹ooSüûšãßÇ\Z_o[6‹ÿßİ„Cı-8ämÆ‘~ÖÒhşİMØÖÃœoºv`k736¹µáK3¦[µâó)ã8vp/{üqàà>ÜÏ¡C$9|ø ´<p`Ÿ$Gørôè;úëş¹”¨´dd?Ä{›=ù´õ;,±lÏTË6Ì·hÃr\'K>r¶b¾é»L}»+lÚò‡5Ûµf¹mkæ´ƒ9mß`¹EkÖ;˜³â½7XÙæ\r>5‡\rm¥ù(6»šò•C{¾´nÉ¾ÎVìëlÎÁV¬w|“£½ì8ĞÅ”£İ­ˆìJ`/kz™qnˆ3ÙreŒñ£l¹>ËCÒ—¦wâì;\"Æ[·¢ãÛ´`£)ËœMøØ¾%ë:µåøâfuæü¬NÄN´ãÂtgb&Ø0Õ\r¿fìö±eãhöOwbÇ8Ìò p™7‹ºù¡7§—x1Ñ™ğ!öœ`M@_K÷³áHok{[pp€úZ²¯·5›;wàk×–léŞïº™³±³	Ÿº´b•sK>qkËÊÎøÈÓŒE®fŒµnÃÔœ8¸={v±aËfvìÜÎÛøî»-lÛ¶UZnÙ²™;·KçìÚµƒíÛ¿c÷îÿÀúÂôze>e÷î1ÛÂŠ>o¶Àó­7èõö;ôyç¶jIßw~GÿwŞdtû6ø´}‡1í[Ò÷­ôkı6ÃMÛ2ÃÙ‘ş-ßbœù;Œ5û>æo3ÁâM¦Ú¼Ã4Ûw™hş3­[1ÓäMfvxƒé~ÇLóß±ÂÎ„yíŞd£+Ì[²Ö®-_8¶e›»Û:¶g—K{v»´åg‚úÙÔÇŠ¸A.œçÂñEéÕò\rº¾õ;ú¾û6ÃŞ~›ñ­ßâ}ëwÙĞÃ‚m½ÌğdÇŞ¦í@[pgºıÌêÜš¼Løz€5ßt`ÏdwÎëÆÉE½™ë‰ïèìîgË¶^V|Ûİœ-½lØÜÓ†M½¬YÕİŒ<-XêfÉ\\‡Ì²oË§vÌp4e¢]†[¼Gï¶ïàõŞt3y—æ­êîÄø!X»z5Ÿ~¹õß|Ãæ-ßH€\n\0 ?—½{wKÌŠ:Å…çHM}ò\\ ÌAW®EcĞ‘ò$‰UË?ÀÍº-&ï¾MN.ôõò`dß^|ºt!»7|ÁŠÙS˜6¨k?˜Í¦O?dõòù|¸h6-œÃÄ±£˜4n4z÷dHoxwgX¿ïß‹½½Ş»½::Ğ©};\\Úµ¡¯›½MZÑí7aİï·[0ä½oÓ‚©6m×îw,°nÇ”·Z°Úº›œL8ÜÓ™õf¿ãˆOw6MíÏ¸î]Ö¥Ö-ŞÄõ­wğz÷zµlÁ€·[0É¤KÛ²sˆkİÛò¹§-kúz2ÎÕ–Îï½ç›o0Æ¼Ólßà}×÷øj#_qà£í˜Õñm&Û¿Ë8ëß1Úâ\r†vxƒ¾­Ş û[oĞÛ¼%Cœ,ğéâÆÜAıY>~4ŸÍÆÖW²uÕ\Z6¯]ËæÏ?gã_ñÙÚµ¬Yı1Ÿ®^ÉÊÕkøä«¯Y»a›¿ûİ»¶I,\r?É;·ÈÎÎ¤¨¨@²·Âö6{ĞÍÎVaW…‡,ı­iRÓ’¤i\n3³Ò$û„W-l²X’óò³¤ÏÈÉÍ>S,ïŞ»IzF\n÷îßâæ­«<NzÀ“”Gdd¦’“.9nÍ³Åˆá/Æ­ô[ÄvI©î§uqL,Åù‰O¹sï&GøzÕ*VÌ˜Å”şƒ×³C=ènÙ–oÒ³Õ;íĞ‰vVÌëbË$/W<í0ï`†™IÜœlqs¶¥»g\'|†ÀÕ¤=Z·¡¯µ-<º°lô6}²‚O?ı˜•k?bİ×_³ñ‹løâ¶}¹Š&ú°|ì>7“õ«—ñÉÇËøôÓ5¬[÷%7®—dıúuMÛ›Ö±eë&¶ïØÂ½;Ø·‡7ÙR?‚ƒ	%::Š+W.Ià‰û×üß…ü=Œş’´7Qš§Lÿ7GŒ‹@4Oş!Ö›¿Tr¼^ïovÆšG ‹Ô¼¿ù3Äç5_#ĞÄùb\0ÛÏÿ€xHÄ1q8.I€¿¾@©,F¯VP¢QRª£’å!SdbĞPa”¡-ómÉ0ç ËÌ\"éşC._ºÆ¹˜hönş”íkæ°~İJ;Ì‘€C¬[÷öîàÛ\r_±ï»oğß±™“Aş„„q:ş4qgc¹ó.é¹idd$¡*ÊE\'Ø£,D¡-DklbQAAOŸ¦J,jcÄƒûóÿ!ş—£Q/…8Â#–ÉŠ¤e3›ÃÒæÿİô/±ù[\"©hq³šÀ/Oh–æI¬7-Ö›\'ä\"¾\\ìŸ\'şˆ8.>W\\\'®ÿùœb»ù6?ÍŸùó‡¡Yšÿü{›$­x²õJäêbäâíez9\nƒ…QÙô\Z;½øNÉOÓ)Rª«\n1(Ó©R?A-Ï¦¤TKn~&ÙyÜI¼%½M¥“a0È‘©óQ¨Ê¦Ø³XL<˜ZQ|/ÌP¡Ñ()ÖÈ¤Wâ	µ(ÎaL3ÀÀŸßKñ»Åï—îËëPG€*Î×ü$¯ïk3išïÓ/±ù[òÙàÿnù¿kÔ¢ÃDN±¾é­/Ò»\n›³oZ¥ô\Z\ZñB½:Wš^¼SBLV^¬SJ×ˆ7Á”¼~¥Xoz-NÓg+tâ\\ñº;ñÚ»¦Ì8.Ş˜¦Wª1(ÕMKñ>ñ\"æXôÏä/üI~yŞ¯¹æ?!ÿãÒü¦ñª½R!½D§RHÛÍbPgK ‹w-‰wŠ7Šè\rhU ÅO\"®m¾ş§7ÈH\"^†!kÊÑ‹sÄ¹Í×¼ê/€ô÷Àúåy¿æšÿ„ü¸YÈ‚Q‚yBDySzë‹VØñ&0tBÅiäé´(´Âa@£SIÇ3Ë›˜ş7Wh½JÈkfK/¨,F%^Ìõú;~bøOßùiÂ?“¿ğû%ùåy¿æšÿ„üKüs{ûËcÿ×y¯ı×ú…Å~¡¦ÿã5±MÕ²¦Atÿ¡~ùÂ©Ÿ>÷\ZCÈßºî_IşW\0üÿä¯Ëÿø¹üÊï“3JšZ\0\0\0\0IEND®B`‚',0,'2024-12-16 02:44:49','2024-12-16 02:44:49');
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
