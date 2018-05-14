/*==============================================================*/
/* DBMS name:      ORACLE Version 11g                           */
/* Created on:     5/13/2018 3:50:49 AM                         */
/*==============================================================*/


alter table ABSENSI
   drop constraint FK_ABSENSI_PEGAWAI_A_PEGAWAI;

alter table BARANG
   drop constraint FK_BARANG_BARANG_JE_KATEGORI;

alter table BARANG
   drop constraint FK_BARANG_BARANG_ME_MERK;

alter table DBELI
   drop constraint FK_DBELI_DBELI_BAR_BARANG;

alter table DBELI
   drop constraint FK_DBELI_DBELI_HBE_HBELI;

alter table DBELI
   drop constraint FK_DBELI_DBELI_SUP_SUPPLIER;

alter table DJUAL
   drop constraint FK_DJUAL_BARANG_HJ_BARANG;

alter table DJUAL
   drop constraint FK_DJUAL_BARANG_HJ_HJUAL;

alter table HJUAL
   drop constraint FK_HJUAL_PEGAWAI_H_PEGAWAI;

alter table POINT_HISTORY
   drop constraint FK_POINT_HI_HJUAL_MEM_HJUAL;

alter table POINT_HISTORY
   drop constraint FK_POINT_HI_HJUAL_MEM_MEMBER;

drop index PEGAWAI_ABSENSI_FK;

drop table ABSENSI cascade constraints;

drop index BARANG_JENIS_FK;

drop index BARANG_MERK_FK;

drop table BARANG cascade constraints;

drop index SUPPLIER_HBELI2_FK;

drop index SUPPLIER_HBELI_FK;

drop index DBELI_BARANG_FK;

drop table DBELI cascade constraints;

drop index BARANG_HJUAL2_FK;

drop index BARANG_HJUAL_FK;

drop table DJUAL cascade constraints;

drop table HBELI cascade constraints;

drop index PEGAWAI_HJUAL_FK;

drop table HJUAL cascade constraints;

drop table KATEGORI cascade constraints;

drop table MEMBER cascade constraints;

drop table MERK cascade constraints;

drop table PEGAWAI cascade constraints;

drop index HJUAL_MEMBER2_FK;

drop index HJUAL_MEMBER_FK;

drop table POINT_HISTORY cascade constraints;

drop table SUPPLIER cascade constraints;

/*==============================================================*/
/* Table: ABSENSI                                               */
/*==============================================================*/
create table ABSENSI 
(
   ID_ABSENSI           VARCHAR2(20)         not null,
   ID_PEGAWAI           VARCHAR2(10),
   WAKTU_DATANG         TIMESTAMP            not null,
   WAKTU_PULANG         TIMESTAMP            not null,
   constraint PK_ABSENSI primary key (ID_ABSENSI)
);

/*==============================================================*/
/* Index: PEGAWAI_ABSENSI_FK                                    */
/*==============================================================*/
create index PEGAWAI_ABSENSI_FK on ABSENSI (
   ID_PEGAWAI ASC
);

/*==============================================================*/
/* Table: BARANG                                                */
/*==============================================================*/
create table BARANG 
(
   ID_BARANG            VARCHAR2(10)         not null,
   ID_KATEGORI          VARCHAR2(10)         not null,
   ID_MERK              VARCHAR2(10)         not null,
   NAMA_BARANG          VARCHAR2(30)         not null,
   HARGA_ASLI_BARANG    NUMBER               not null,
   HARGA_JUAL_BARANG    NUMBER               not null,
   STOK_BARANG          NUMBER               not null,
   DESKRIPSI_BARANG     VARCHAR2(200),
   GAMBAR_BARANG        VARCHAR2(50),
   constraint PK_BARANG primary key (ID_BARANG)
);

/*==============================================================*/
/* Index: BARANG_MERK_FK                                        */
/*==============================================================*/
create index BARANG_MERK_FK on BARANG (
   ID_MERK ASC
);

/*==============================================================*/
/* Index: BARANG_JENIS_FK                                       */
/*==============================================================*/
create index BARANG_JENIS_FK on BARANG (
   ID_KATEGORI ASC
);

/*==============================================================*/
/* Table: DBELI                                                 */
/*==============================================================*/
create table DBELI 
(
   ID_SUPPLIER          VARCHAR2(10)         not null,
   ID_BARANG            VARCHAR2(10)         not null,
   ID_HBELI             VARCHAR2(20)         not null,
   JUMLAH               NUMBER               not null,
   SUBTOTAL             NUMBER               not null,
   constraint PK_DBELI primary key (ID_SUPPLIER, ID_BARANG, ID_HBELI)
);

/*==============================================================*/
/* Index: DBELI_BARANG_FK                                       */
/*==============================================================*/
create index DBELI_BARANG_FK on DBELI (
   ID_BARANG ASC
);

/*==============================================================*/
/* Index: SUPPLIER_HBELI_FK                                     */
/*==============================================================*/
create index SUPPLIER_HBELI_FK on DBELI (
   ID_SUPPLIER ASC
);

/*==============================================================*/
/* Index: SUPPLIER_HBELI2_FK                                    */
/*==============================================================*/
create index SUPPLIER_HBELI2_FK on DBELI (
   ID_HBELI ASC
);

/*==============================================================*/
/* Table: DJUAL                                                 */
/*==============================================================*/
create table DJUAL 
(
   ID_BARANG            VARCHAR2(10)         not null,
   ID_HJUAL             VARCHAR2(20)         not null,
   JUMLAH               NUMBER               not null,
   SUBTOTAL             NUMBER               not null,
   constraint PK_DJUAL primary key (ID_BARANG, ID_HJUAL)
);

/*==============================================================*/
/* Index: BARANG_HJUAL_FK                                       */
/*==============================================================*/
create index BARANG_HJUAL_FK on DJUAL (
   ID_BARANG ASC
);

/*==============================================================*/
/* Index: BARANG_HJUAL2_FK                                      */
/*==============================================================*/
create index BARANG_HJUAL2_FK on DJUAL (
   ID_HJUAL ASC
);

/*==============================================================*/
/* Table: HBELI                                                 */
/*==============================================================*/
create table HBELI 
(
   ID_HBELI             VARCHAR2(20)         not null,
   TANGGAL_HBELI        TIMESTAMP            not null,
   TOTAL_HBELI          NUMBER               not null,
   constraint PK_HBELI primary key (ID_HBELI)
);

/*==============================================================*/
/* Table: HJUAL                                                 */
/*==============================================================*/
create table HJUAL 
(
   ID_HJUAL             VARCHAR2(20)         not null,
   ID_PEGAWAI           VARCHAR2(10),
   TANGGAL_HJUAL        TIMESTAMP            not null,
   TOTAL_HJUAL          NUMBER               not null,
   constraint PK_HJUAL primary key (ID_HJUAL)
);

/*==============================================================*/
/* Index: PEGAWAI_HJUAL_FK                                      */
/*==============================================================*/
create index PEGAWAI_HJUAL_FK on HJUAL (
   ID_PEGAWAI ASC
);

/*==============================================================*/
/* Table: KATEGORI                                              */
/*==============================================================*/
create table KATEGORI 
(
   ID_KATEGORI          VARCHAR2(10)         not null,
   NAMA_KATEGORI        VARCHAR2(30)         not null,
   constraint PK_KATEGORI primary key (ID_KATEGORI)
);

/*==============================================================*/
/* Table: MEMBER                                                */
/*==============================================================*/
create table MEMBER 
(
   ID_MEMBER            VARCHAR2(30)         not null,
   NAMA_MEMBER          VARCHAR2(30)         not null,
   TGL_LAHIR_MEMBER     VARCHAR2(30)         not null,
   JK_MEMBER            NUMBER               not null,
   ALAMAT_MEMBER        VARCHAR2(30)         not null,
   FOTO_MEMBER          VARCHAR2(50 CHAR),
   PASSWORD_MEMBER      VARCHAR2(30)         not null,
   constraint PK_MEMBER primary key (ID_MEMBER)
);

/*==============================================================*/
/* Table: MERK                                                  */
/*==============================================================*/
create table MERK 
(
   ID_MERK              VARCHAR2(10)         not null,
   NAMA_MERK            VARCHAR2(30)         not null,
   constraint PK_MERK primary key (ID_MERK)
);

/*==============================================================*/
/* Table: PEGAWAI                                               */
/*==============================================================*/
create table PEGAWAI 
(
   ID_PEGAWAI           VARCHAR2(10)         not null,
   NAMA_PEGAWAI         VARCHAR2(30)         not null,
   TGL_LAHIR_PEGAWAI    DATE                 not null,
   JK_PEGAWAI           NUMBER               not null,
   ALAMAT_PEGAWAI       VARCHAR2(30)         not null,
   TELEPON_PEGAWAI      VARCHAR2(30)         not null,
   FOTO_PEGAWAI         VARCHAR2(50),
   ROLE_PEGAWAI         NUMBER               not null,
   PASSWORD_PEGAWAI     VARCHAR2(30)         not null,
   constraint PK_PEGAWAI primary key (ID_PEGAWAI)
);

/*==============================================================*/
/* Table: POINT_HISTORY                                         */
/*==============================================================*/
create table POINT_HISTORY 
(
   ID_HJUAL             VARCHAR2(20)         not null,
   ID_MEMBER            VARCHAR2(30)         not null,
   POINT                NUMBER               not null,
   constraint PK_POINT_HISTORY primary key (ID_HJUAL, ID_MEMBER)
);

/*==============================================================*/
/* Index: HJUAL_MEMBER_FK                                       */
/*==============================================================*/
create index HJUAL_MEMBER_FK on POINT_HISTORY (
   ID_HJUAL ASC
);

/*==============================================================*/
/* Index: HJUAL_MEMBER2_FK                                      */
/*==============================================================*/
create index HJUAL_MEMBER2_FK on POINT_HISTORY (
   ID_MEMBER ASC
);

/*==============================================================*/
/* Table: SUPPLIER                                              */
/*==============================================================*/
create table SUPPLIER 
(
   ID_SUPPLIER          VARCHAR2(10)         not null,
   NAMA_SUPPLIER        VARCHAR2(30)         not null,
   ALAMAT_SUPPLIER      VARCHAR2(30)         not null,
   TELEPON_SUPPLIER     VARCHAR2(30)         not null,
   constraint PK_SUPPLIER primary key (ID_SUPPLIER)
);

alter table ABSENSI
   add constraint FK_ABSENSI_PEGAWAI_A_PEGAWAI foreign key (ID_PEGAWAI)
      references PEGAWAI (ID_PEGAWAI);

alter table BARANG
   add constraint FK_BARANG_BARANG_JE_KATEGORI foreign key (ID_KATEGORI)
      references KATEGORI (ID_KATEGORI);

alter table BARANG
   add constraint FK_BARANG_BARANG_ME_MERK foreign key (ID_MERK)
      references MERK (ID_MERK);

alter table DBELI
   add constraint FK_DBELI_DBELI_BAR_BARANG foreign key (ID_BARANG)
      references BARANG (ID_BARANG);

alter table DBELI
   add constraint FK_DBELI_DBELI_HBE_HBELI foreign key (ID_HBELI)
      references HBELI (ID_HBELI);

alter table DBELI
   add constraint FK_DBELI_DBELI_SUP_SUPPLIER foreign key (ID_SUPPLIER)
      references SUPPLIER (ID_SUPPLIER);

alter table DJUAL
   add constraint FK_DJUAL_BARANG_HJ_BARANG foreign key (ID_BARANG)
      references BARANG (ID_BARANG);

alter table DJUAL
   add constraint FK_DJUAL_BARANG_HJ_HJUAL foreign key (ID_HJUAL)
      references HJUAL (ID_HJUAL);

alter table HJUAL
   add constraint FK_HJUAL_PEGAWAI_H_PEGAWAI foreign key (ID_PEGAWAI)
      references PEGAWAI (ID_PEGAWAI);

alter table POINT_HISTORY
   add constraint FK_POINT_HI_HJUAL_MEM_HJUAL foreign key (ID_HJUAL)
      references HJUAL (ID_HJUAL);

alter table POINT_HISTORY
   add constraint FK_POINT_HI_HJUAL_MEM_MEMBER foreign key (ID_MEMBER)
      references MEMBER (ID_MEMBER);

INSERT INTO KATEGORI VALUES ('K0001','Laptop');
INSERT INTO KATEGORI VALUES ('K0002','Kamera');
INSERT INTO KATEGORI VALUES ('K0003','Handphone');
INSERT INTO KATEGORI VALUES ('K0004','Tablet');
INSERT INTO KATEGORI VALUES ('K0005','Powerbank');

INSERT INTO MERK VALUES ('M0001','Asus');
INSERT INTO MERK VALUES ('M0002','Canon');
INSERT INTO MERK VALUES ('M0003','Nikon');
INSERT INTO MERK VALUES ('M0004','Dell');
INSERT INTO MERK VALUES ('M0005','XiaoMi');

INSERT INTO BARANG VALUES ('B0001','K0001','M0001','Asus ROG',20000000,22000000,9,NULL,NULL);
INSERT INTO BARANG VALUES ('B0002','K0002','M0002','Canon 500D',6000000,6600000,9,NULL,NULL);
INSERT INTO BARANG VALUES ('B0003','K0002','M0003','Nikon 1300',5000000,5500000,3,NULL,NULL);
INSERT INTO BARANG VALUES ('B0004','K0001','M0004','Dell 14041',7000000,7700000,9,NULL,NULL);
INSERT INTO BARANG VALUES ('B0005','K0005','M0005','PB-007',200000,220000,17,NULL,NULL);

INSERT INTO PEGAWAI VALUES ('P0001','Susi Susanti',TO_DATE('1988-10-12','YYYY-MM-DD'),0,'Jl.Rajawali 800',4567889,NULL,1,'pss88001');
INSERT INTO PEGAWAI VALUES ('P0002','Tom Mitchell',TO_DATE('1996-09-06','YYYY-MM-DD'),1,'Jl.Singaperbangsa 80',9876662,NULL,1,'ptm96002');
INSERT INTO PEGAWAI VALUES ('P0003','Martin Suryajaya',TO_DATE('1980-03-11','YYYY-MM-DD'),1,'Jl.MT Haryono 700',2766563,NULL,1,'pms80003');
INSERT INTO PEGAWAI VALUES ('P0004','Rose Maxwell',TO_DATE('1990-05-05','YYYY-MM-DD'),0,'Jl.Sukolilo 88',2344443,NULL,2,'prm90004');
INSERT INTO PEGAWAI VALUES ('P0005','Pevita Pearce',TO_DATE('1987-04-03','YYYY-MM-DD'),0,'Jl.Pasteur 55',4532343,NULL,2,'ppp87005');

INSERT INTO ABSENSI VALUES ('A13032018001','P0004',TO_DATE('2018-03-13 07:30:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-13 16:30:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A13032018002','P0005',TO_DATE('2018-03-13 07:35:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-13 16:35:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A14032018001','P0004',TO_DATE('2018-03-14 07:30:50','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-14 17:00:50','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A14032018002','P0005',TO_DATE('2018-03-14 07:30:55','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-14 17:30:55','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A15032018001','P0004',TO_DATE('2018-03-15 07:31:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-15 16:55:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A15032018002','P0005',TO_DATE('2018-03-15 07:33:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-15 16:35:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A20032018001','P0001',TO_DATE('2018-03-20 07:30:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-20 16:30:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A20032018002','P0002',TO_DATE('2018-03-20 07:35:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-20 16:35:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A20032018003','P0003',TO_DATE('2018-03-20 07:37:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-20 16:35:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A21032018001','P0001',TO_DATE('2018-03-21 07:30:44','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-21 16:30:44','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A21032018002','P0002',TO_DATE('2018-03-21 07:30:45','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-21 16:30:45','YYYY-MM-DD HH24:MI:SS'));
INSERT INTO ABSENSI VALUES ('A21032018003','P0003',TO_DATE('2018-03-21 07:30:46','YYYY-MM-DD HH24:MI:SS'),TO_DATE('2018-03-21 16:30:46','YYYY-MM-DD HH24:MI:SS'));

INSERT INTO SUPPLIER VALUES ('S0001','PT.Makmur Jaya','Jl.Ngagel Jaya 786',3687651);
INSERT INTO SUPPLIER VALUES ('S0002','PT.Computindo Golden','Jl.Rajawali 100',7265498);
INSERT INTO SUPPLIER VALUES ('S0003','PT.Sentosa Abadi','Jl.Kalidami 20',2345553);
INSERT INTO SUPPLIER VALUES ('S0004','PT.Elektronika Jaya','Jl.Basuki Rahmat 35',1234444);
INSERT INTO SUPPLIER VALUES ('S0005','PT.Sumber Abadi','Jl.Pandegiling 40',5678888);

INSERT INTO MEMBER VALUES ('M0001','Roy Kiyoshi',TO_DATE('1989-10-10','YYYY-MM-DD'),1,'Jl.Senayan Timur 90',NULL,'mrk001');
INSERT INTO MEMBER VALUES ('M0002','Bob Martin',TO_DATE('1965-10-12','YYYY-MM-DD'),1,'Jl.Meruya Barat 88',NULL,'mbr002');
INSERT INTO MEMBER VALUES ('M0003','Dian Sastro',TO_DATE('1988-05-05','YYYY-MM-DD'),0,'Jl.Kemang Timur 80',NULL,'mds003');
INSERT INTO MEMBER VALUES ('M0004','Tara Basro',TO_DATE('1990-04-03','YYYY-MM-DD'),0,'Jl.Darmo 90',NULL,'mtb004');
INSERT INTO MEMBER VALUES ('M0005','Richo Kyle',TO_DATE('1989-03-04','YYYY-MM-DD'),1,'Jl.Dinoyo 88',NULL,'mrk005');

INSERT INTO HBELI VALUES ('HB13032018001',TO_DATE('2018-03-13 10:30:44','YYYY-MM-DD HH24:MI:SS'),200000000);
INSERT INTO HBELI VALUES ('HB13032018002',TO_DATE('2018-03-13 10:35:44','YYYY-MM-DD HH24:MI:SS'),30000000);
INSERT INTO HBELI VALUES ('HB14032018001',TO_DATE('2018-03-14 10:30:50','YYYY-MM-DD HH24:MI:SS'),25000000);
INSERT INTO HBELI VALUES ('HB14032018002',TO_DATE('2018-03-14 13:30:44','YYYY-MM-DD HH24:MI:SS'),70000000);
INSERT INTO HBELI VALUES ('HB15032018001',TO_DATE('2018-03-15 14:30:44','YYYY-MM-DD HH24:MI:SS'),4000000);

INSERT INTO DBELI VALUES ('S0001','B0001','HB13032018001',10,200000000);
INSERT INTO DBELI VALUES ('S0002','B0002','HB13032018002',5,30000000);
INSERT INTO DBELI VALUES ('S0003','B0003','HB14032018001',5,25000000);
INSERT INTO DBELI VALUES ('S0004','B0004','HB14032018002',10,70000000);
INSERT INTO DBELI VALUES ('S0005','B0005','HB15032018001',20,4000000);

INSERT INTO HJUAL VALUES ('HJ20032018001','P0001',TO_DATE('2018-03-20 10:30:44','YYYY-MM-DD HH24:MI:SS'),22000000);
INSERT INTO HJUAL VALUES ('HJ20032018002','P0002',TO_DATE('2018-03-20 10:35:44','YYYY-MM-DD HH24:MI:SS'),6600000);
INSERT INTO HJUAL VALUES ('HJ21032018001','P0003',TO_DATE('2018-03-21 11:40:50','YYYY-MM-DD HH24:MI:SS'),11000000);
INSERT INTO HJUAL VALUES ('HJ21032018002','P0001',TO_DATE('2018-03-21 13:30:44','YYYY-MM-DD HH24:MI:SS'),7700000);
INSERT INTO HJUAL VALUES ('HJ21032018003','P0002',TO_DATE('2018-03-21 14:30:44','YYYY-MM-DD HH24:MI:SS'),660000);

INSERT INTO DJUAL VALUES ('B0001','HJ20032018001',1,22000000);
INSERT INTO DJUAL VALUES ('B0002','HJ20032018002',1,6600000);
INSERT INTO DJUAL VALUES ('B0003','HJ21032018001',2,11000000);
INSERT INTO DJUAL VALUES ('B0004','HJ21032018002',1,7700000);
INSERT INTO DJUAL VALUES ('B0005','HJ21032018003',3,660000);

INSERT INTO POINT_HISTORY VALUES ('HJ20032018001','M0001',220);
INSERT INTO POINT_HISTORY VALUES ('HJ20032018002','M0002',66);
INSERT INTO POINT_HISTORY VALUES ('HJ21032018001','M0003',110);
INSERT INTO POINT_HISTORY VALUES ('HJ21032018002','M0004',77);
INSERT INTO POINT_HISTORY VALUES ('HJ21032018003','M0005',6.6);

commit;

