toc.dat                                                                                             0000600 0004000 0002000 00000045030 14416323326 0014445 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        PGDMP       *                    {           MeetMePlusDB    15.2    15.2 ?    @           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false         A           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false         B           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false         C           1262    16398    MeetMePlusDB    DATABASE     �   CREATE DATABASE "MeetMePlusDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Hebrew_Israel.1252';
    DROP DATABASE "MeetMePlusDB";
                postgres    false         �            1259    16438    tblchats    TABLE     r   CREATE TABLE public.tblchats (
    id integer NOT NULL,
    user1 integer NOT NULL,
    user2 integer NOT NULL
);
    DROP TABLE public.tblchats;
       public         heap    postgres    false         �            1259    16437    tblchats_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tblchats_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.tblchats_id_seq;
       public          postgres    false    221         D           0    0    tblchats_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.tblchats_id_seq OWNED BY public.tblchats.id;
          public          postgres    false    220         �            1259    16421 
   tblfriends    TABLE     b   CREATE TABLE public.tblfriends (
    id integer NOT NULL,
    user1 integer,
    user2 integer
);
    DROP TABLE public.tblfriends;
       public         heap    postgres    false         �            1259    16420    tblfriends_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tblfriends_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 (   DROP SEQUENCE public.tblfriends_id_seq;
       public          postgres    false    219         E           0    0    tblfriends_id_seq    SEQUENCE OWNED BY     G   ALTER SEQUENCE public.tblfriends_id_seq OWNED BY public.tblfriends.id;
          public          postgres    false    218         �            1259    16455    tblmeetings    TABLE     �   CREATE TABLE public.tblmeetings (
    id integer NOT NULL,
    creator integer NOT NULL,
    description text NOT NULL,
    location text NOT NULL,
    name character varying(50) NOT NULL,
    meetingtime text NOT NULL
);
    DROP TABLE public.tblmeetings;
       public         heap    postgres    false         �            1259    16454    tblmeetings_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tblmeetings_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.tblmeetings_id_seq;
       public          postgres    false    223         F           0    0    tblmeetings_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.tblmeetings_id_seq OWNED BY public.tblmeetings.id;
          public          postgres    false    222         �            1259    16469    tblmessages    TABLE     �   CREATE TABLE public.tblmessages (
    id integer NOT NULL,
    sender integer NOT NULL,
    sendingtime text NOT NULL,
    content text NOT NULL,
    chat integer NOT NULL
);
    DROP TABLE public.tblmessages;
       public         heap    postgres    false         �            1259    16468    tblmessages_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tblmessages_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.tblmessages_id_seq;
       public          postgres    false    225         G           0    0    tblmessages_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.tblmessages_id_seq OWNED BY public.tblmessages.id;
          public          postgres    false    224         �            1259    16488    tblparticipentsinmeeting    TABLE     �   CREATE TABLE public.tblparticipentsinmeeting (
    id integer NOT NULL,
    participent integer NOT NULL,
    meeting integer NOT NULL
);
 ,   DROP TABLE public.tblparticipentsinmeeting;
       public         heap    postgres    false         �            1259    16487    tblparticipentsinmeeting_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tblparticipentsinmeeting_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 6   DROP SEQUENCE public.tblparticipentsinmeeting_id_seq;
       public          postgres    false    227         H           0    0    tblparticipentsinmeeting_id_seq    SEQUENCE OWNED BY     c   ALTER SEQUENCE public.tblparticipentsinmeeting_id_seq OWNED BY public.tblparticipentsinmeeting.id;
          public          postgres    false    226         �            1259    16407    tblusers    TABLE     �  CREATE TABLE public.tblusers (
    id integer NOT NULL,
    username character varying(20) NOT NULL,
    password character varying(18) NOT NULL,
    firstname character varying(20) NOT NULL,
    lastname character varying(20) NOT NULL,
    gender boolean NOT NULL,
    phone character varying(10) NOT NULL,
    birthday character varying(50) NOT NULL,
    email character varying(50) NOT NULL,
    interests text NOT NULL,
    profpicext character varying(10) NOT NULL,
    usertype integer NOT NULL
);
    DROP TABLE public.tblusers;
       public         heap    postgres    false         �            1259    16406    tblusers_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tblusers_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.tblusers_id_seq;
       public          postgres    false    217         I           0    0    tblusers_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.tblusers_id_seq OWNED BY public.tblusers.id;
          public          postgres    false    216         �            1259    16400    tblusertypes    TABLE     g   CREATE TABLE public.tblusertypes (
    id integer NOT NULL,
    name character varying(20) NOT NULL
);
     DROP TABLE public.tblusertypes;
       public         heap    postgres    false         �            1259    16399    tblusertypes_id_seq    SEQUENCE     �   CREATE SEQUENCE public.tblusertypes_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.tblusertypes_id_seq;
       public          postgres    false    215         J           0    0    tblusertypes_id_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.tblusertypes_id_seq OWNED BY public.tblusertypes.id;
          public          postgres    false    214         �           2604    16441    tblchats id    DEFAULT     j   ALTER TABLE ONLY public.tblchats ALTER COLUMN id SET DEFAULT nextval('public.tblchats_id_seq'::regclass);
 :   ALTER TABLE public.tblchats ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    221    220    221         �           2604    16424    tblfriends id    DEFAULT     n   ALTER TABLE ONLY public.tblfriends ALTER COLUMN id SET DEFAULT nextval('public.tblfriends_id_seq'::regclass);
 <   ALTER TABLE public.tblfriends ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    219    218    219         �           2604    16458    tblmeetings id    DEFAULT     p   ALTER TABLE ONLY public.tblmeetings ALTER COLUMN id SET DEFAULT nextval('public.tblmeetings_id_seq'::regclass);
 =   ALTER TABLE public.tblmeetings ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    223    222    223         �           2604    16472    tblmessages id    DEFAULT     p   ALTER TABLE ONLY public.tblmessages ALTER COLUMN id SET DEFAULT nextval('public.tblmessages_id_seq'::regclass);
 =   ALTER TABLE public.tblmessages ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    225    224    225         �           2604    16491    tblparticipentsinmeeting id    DEFAULT     �   ALTER TABLE ONLY public.tblparticipentsinmeeting ALTER COLUMN id SET DEFAULT nextval('public.tblparticipentsinmeeting_id_seq'::regclass);
 J   ALTER TABLE public.tblparticipentsinmeeting ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    226    227    227         �           2604    16410    tblusers id    DEFAULT     j   ALTER TABLE ONLY public.tblusers ALTER COLUMN id SET DEFAULT nextval('public.tblusers_id_seq'::regclass);
 :   ALTER TABLE public.tblusers ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    216    217    217         �           2604    16403    tblusertypes id    DEFAULT     r   ALTER TABLE ONLY public.tblusertypes ALTER COLUMN id SET DEFAULT nextval('public.tblusertypes_id_seq'::regclass);
 >   ALTER TABLE public.tblusertypes ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    214    215    215         7          0    16438    tblchats 
   TABLE DATA           4   COPY public.tblchats (id, user1, user2) FROM stdin;
    public          postgres    false    221       3383.dat 5          0    16421 
   tblfriends 
   TABLE DATA           6   COPY public.tblfriends (id, user1, user2) FROM stdin;
    public          postgres    false    219       3381.dat 9          0    16455    tblmeetings 
   TABLE DATA           \   COPY public.tblmeetings (id, creator, description, location, name, meetingtime) FROM stdin;
    public          postgres    false    223       3385.dat ;          0    16469    tblmessages 
   TABLE DATA           M   COPY public.tblmessages (id, sender, sendingtime, content, chat) FROM stdin;
    public          postgres    false    225       3387.dat =          0    16488    tblparticipentsinmeeting 
   TABLE DATA           L   COPY public.tblparticipentsinmeeting (id, participent, meeting) FROM stdin;
    public          postgres    false    227       3389.dat 3          0    16407    tblusers 
   TABLE DATA           �   COPY public.tblusers (id, username, password, firstname, lastname, gender, phone, birthday, email, interests, profpicext, usertype) FROM stdin;
    public          postgres    false    217       3379.dat 1          0    16400    tblusertypes 
   TABLE DATA           0   COPY public.tblusertypes (id, name) FROM stdin;
    public          postgres    false    215       3377.dat K           0    0    tblchats_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.tblchats_id_seq', 8, true);
          public          postgres    false    220         L           0    0    tblfriends_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.tblfriends_id_seq', 6, true);
          public          postgres    false    218         M           0    0    tblmeetings_id_seq    SEQUENCE SET     @   SELECT pg_catalog.setval('public.tblmeetings_id_seq', 2, true);
          public          postgres    false    222         N           0    0    tblmessages_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.tblmessages_id_seq', 12, true);
          public          postgres    false    224         O           0    0    tblparticipentsinmeeting_id_seq    SEQUENCE SET     M   SELECT pg_catalog.setval('public.tblparticipentsinmeeting_id_seq', 4, true);
          public          postgres    false    226         P           0    0    tblusers_id_seq    SEQUENCE SET     =   SELECT pg_catalog.setval('public.tblusers_id_seq', 3, true);
          public          postgres    false    216         Q           0    0    tblusertypes_id_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.tblusertypes_id_seq', 1, false);
          public          postgres    false    214         �           2606    16426    tblfriends pk_tblfriends 
   CONSTRAINT     V   ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT pk_tblfriends PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.tblfriends DROP CONSTRAINT pk_tblfriends;
       public            postgres    false    219         �           2606    16443    tblchats tblchats_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.tblchats DROP CONSTRAINT tblchats_pkey;
       public            postgres    false    221         �           2606    16462    tblmeetings tblmeetings_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.tblmeetings
    ADD CONSTRAINT tblmeetings_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.tblmeetings DROP CONSTRAINT tblmeetings_pkey;
       public            postgres    false    223         �           2606    16476    tblmessages tblmessages_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_pkey PRIMARY KEY (id);
 F   ALTER TABLE ONLY public.tblmessages DROP CONSTRAINT tblmessages_pkey;
       public            postgres    false    225         �           2606    16493 6   tblparticipentsinmeeting tblparticipentsinmeeting_pkey 
   CONSTRAINT     t   ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_pkey PRIMARY KEY (id);
 `   ALTER TABLE ONLY public.tblparticipentsinmeeting DROP CONSTRAINT tblparticipentsinmeeting_pkey;
       public            postgres    false    227         �           2606    16414    tblusers tblusers_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.tblusers
    ADD CONSTRAINT tblusers_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.tblusers DROP CONSTRAINT tblusers_pkey;
       public            postgres    false    217         �           2606    16405    tblusertypes tblusertypes_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.tblusertypes
    ADD CONSTRAINT tblusertypes_pkey PRIMARY KEY (id);
 H   ALTER TABLE ONLY public.tblusertypes DROP CONSTRAINT tblusertypes_pkey;
       public            postgres    false    215         �           2606    16427 !   tblfriends fk_tblfriends_tblusers    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT fk_tblfriends_tblusers FOREIGN KEY (user1) REFERENCES public.tblusers(id);
 K   ALTER TABLE ONLY public.tblfriends DROP CONSTRAINT fk_tblfriends_tblusers;
       public          postgres    false    3213    217    219         �           2606    16432 "   tblfriends fk_tblfriends_tblusers1    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT fk_tblfriends_tblusers1 FOREIGN KEY (user2) REFERENCES public.tblusers(id);
 L   ALTER TABLE ONLY public.tblfriends DROP CONSTRAINT fk_tblfriends_tblusers1;
       public          postgres    false    3213    219    217         �           2606    16415 !   tblusers fk_tblusers_tblusertypes    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblusers
    ADD CONSTRAINT fk_tblusers_tblusertypes FOREIGN KEY (usertype) REFERENCES public.tblusertypes(id);
 K   ALTER TABLE ONLY public.tblusers DROP CONSTRAINT fk_tblusers_tblusertypes;
       public          postgres    false    217    3211    215         �           2606    16444    tblchats tblchats_user1_fkey    FK CONSTRAINT     |   ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_user1_fkey FOREIGN KEY (user1) REFERENCES public.tblusers(id);
 F   ALTER TABLE ONLY public.tblchats DROP CONSTRAINT tblchats_user1_fkey;
       public          postgres    false    217    221    3213         �           2606    16449    tblchats tblchats_user2_fkey    FK CONSTRAINT     |   ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_user2_fkey FOREIGN KEY (user2) REFERENCES public.tblusers(id);
 F   ALTER TABLE ONLY public.tblchats DROP CONSTRAINT tblchats_user2_fkey;
       public          postgres    false    217    221    3213         �           2606    16463 $   tblmeetings tblmeetings_creator_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblmeetings
    ADD CONSTRAINT tblmeetings_creator_fkey FOREIGN KEY (creator) REFERENCES public.tblusers(id);
 N   ALTER TABLE ONLY public.tblmeetings DROP CONSTRAINT tblmeetings_creator_fkey;
       public          postgres    false    217    3213    223         �           2606    16482 !   tblmessages tblmessages_chat_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_chat_fkey FOREIGN KEY (chat) REFERENCES public.tblchats(id);
 K   ALTER TABLE ONLY public.tblmessages DROP CONSTRAINT tblmessages_chat_fkey;
       public          postgres    false    225    221    3217         �           2606    16477 #   tblmessages tblmessages_sender_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_sender_fkey FOREIGN KEY (sender) REFERENCES public.tblusers(id);
 M   ALTER TABLE ONLY public.tblmessages DROP CONSTRAINT tblmessages_sender_fkey;
       public          postgres    false    217    3213    225         �           2606    16499 >   tblparticipentsinmeeting tblparticipentsinmeeting_meeting_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_meeting_fkey FOREIGN KEY (meeting) REFERENCES public.tblmeetings(id);
 h   ALTER TABLE ONLY public.tblparticipentsinmeeting DROP CONSTRAINT tblparticipentsinmeeting_meeting_fkey;
       public          postgres    false    227    3219    223         �           2606    16494 B   tblparticipentsinmeeting tblparticipentsinmeeting_participent_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_participent_fkey FOREIGN KEY (participent) REFERENCES public.tblusers(id);
 l   ALTER TABLE ONLY public.tblparticipentsinmeeting DROP CONSTRAINT tblparticipentsinmeeting_participent_fkey;
       public          postgres    false    3213    227    217                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                3383.dat                                                                                            0000600 0004000 0002000 00000000032 14416323326 0014251 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        2	3	15
3	3	13
8	14	3
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      3381.dat                                                                                            0000600 0004000 0002000 00000000122 14416323326 0014247 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        25	1	13
28	14	9
35	15	1
36	15	9
37	15	14
1	3	13
2	3	15
4	14	3
5	14	1
6	14	13
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                              3385.dat                                                                                            0000600 0004000 0002000 00000000771 14416323326 0014265 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        8	9	come and shop with me I'm lonely	Ice Mall	Shopping	07/04/2022 20:00
11	12	Just a testing, doesn't really matter what I write	Zoom	Test meeting #1	09/05/2022 00:00
12	13	Batch Batch Batch Batch Batch Batch Batch	Batch	Batch	17/05/2022 12:00
14	14	Hi! I just joined the app, I would like to test it by making an interesting meeting. Come join me!	Kinamon 14	Just joined	28/05/2022 14:00
1	3	Come watch Titanic with me	Sirpad 11	Watch Titanic	10/04/2023 21:43
2	1	Check	Check	Check	17/04/2023 12:49
\.


       3387.dat                                                                                            0000600 0004000 0002000 00000000420 14416323326 0014256 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        3	3	2023-04-10 11:23:57.994804	Dorinn come to Eilat	2
4	3	2023-04-10 11:24:30.794657	It's so hot we can go in the pool	2
5	3	2023-04-10 11:24:36.390759	or go to the sea	2
6	3	2023-04-10 11:24:44.278541	So you coming?	2
7	3	2023-04-10 11:24:57.177524	Dad what's up?	3
\.


                                                                                                                                                                                                                                                3389.dat                                                                                            0000600 0004000 0002000 00000000071 14416323326 0014262 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        22	13	11
23	1	14
25	1	8
1	3	12
2	3	11
3	3	14
4	1	11
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                       3379.dat                                                                                            0000600 0004000 0002000 00000001751 14416323326 0014267 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        9	ShiraYa	Sh1ra	Shira	Yarhi	f	1234567892	Nov 11 2003 12:00AM	Shiraya@gmail.com	Reading,Fishing,Crafting,Yoga,Hiking,Cooking	.jpg	2
12	YuvalYa5	YuvalYa5	Yuval	Yarhi	t	0507625050	Aug 25 2002 12:00AM	yarhiyuval94@gmail.com	Traveling,Hiking,Listening to music,Yoga,Bird Watching	.jpg	2
14	galTzarfati	Gg123456	Gal	Tzarfati	f	0527275418	Jul 7 1990 12:00AM	Tzarfati.Gal@gmail.com	Reading,Traveling,Watching TV,Cooking	.jpg	2
15	DorinT	DorinT	Dorin	Talmoud	f	0536985415	Feb  7 1990 12:00AM	Dorin.Talmoud@gmail.com	Reading,Traveling,Hiking,Cooking	.jpg	2
3	NivZar	NivZar	Niv	Zarfati	t	0524292644	1993-10-30 00:00:00	niv.zar@gmail.com	Traveling,Watching TV,Video Games,Listening to music,Cooking	.jpg	2
13	earonc	Az050565	Aharon	Zarfati	t	0537512354	May  5 1965 12:00AM	earonc@walla.com	Traveling,Crafting,Watching TV,Listening to music	.jpg	2
1	shahar015	Sz05056565!	Shahar	Zarfati	t	0526770488	2004-08-01 00:00:00	shahar0151@gmail.com	Traveling,Watching TV,Listening to music,Video Games,Cooking	.jpg	1
\.


                       3377.dat                                                                                            0000600 0004000 0002000 00000000024 14416323326 0014255 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        1	Admin
2	User
\.


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            restore.sql                                                                                         0000600 0004000 0002000 00000035137 14416323326 0015401 0                                                                                                    ustar 00postgres                        postgres                        0000000 0000000                                                                                                                                                                        --
-- NOTE:
--
-- File paths need to be edited. Search for $$PATH$$ and
-- replace it with the path to the directory containing
-- the extracted data files.
--
--
-- PostgreSQL database dump
--

-- Dumped from database version 15.2
-- Dumped by pg_dump version 15.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

DROP DATABASE "MeetMePlusDB";
--
-- Name: MeetMePlusDB; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "MeetMePlusDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Hebrew_Israel.1252';


ALTER DATABASE "MeetMePlusDB" OWNER TO postgres;

\connect "MeetMePlusDB"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: tblchats; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblchats (
    id integer NOT NULL,
    user1 integer NOT NULL,
    user2 integer NOT NULL
);


ALTER TABLE public.tblchats OWNER TO postgres;

--
-- Name: tblchats_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblchats_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblchats_id_seq OWNER TO postgres;

--
-- Name: tblchats_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblchats_id_seq OWNED BY public.tblchats.id;


--
-- Name: tblfriends; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblfriends (
    id integer NOT NULL,
    user1 integer,
    user2 integer
);


ALTER TABLE public.tblfriends OWNER TO postgres;

--
-- Name: tblfriends_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblfriends_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblfriends_id_seq OWNER TO postgres;

--
-- Name: tblfriends_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblfriends_id_seq OWNED BY public.tblfriends.id;


--
-- Name: tblmeetings; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblmeetings (
    id integer NOT NULL,
    creator integer NOT NULL,
    description text NOT NULL,
    location text NOT NULL,
    name character varying(50) NOT NULL,
    meetingtime text NOT NULL
);


ALTER TABLE public.tblmeetings OWNER TO postgres;

--
-- Name: tblmeetings_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblmeetings_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblmeetings_id_seq OWNER TO postgres;

--
-- Name: tblmeetings_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblmeetings_id_seq OWNED BY public.tblmeetings.id;


--
-- Name: tblmessages; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblmessages (
    id integer NOT NULL,
    sender integer NOT NULL,
    sendingtime text NOT NULL,
    content text NOT NULL,
    chat integer NOT NULL
);


ALTER TABLE public.tblmessages OWNER TO postgres;

--
-- Name: tblmessages_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblmessages_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblmessages_id_seq OWNER TO postgres;

--
-- Name: tblmessages_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblmessages_id_seq OWNED BY public.tblmessages.id;


--
-- Name: tblparticipentsinmeeting; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblparticipentsinmeeting (
    id integer NOT NULL,
    participent integer NOT NULL,
    meeting integer NOT NULL
);


ALTER TABLE public.tblparticipentsinmeeting OWNER TO postgres;

--
-- Name: tblparticipentsinmeeting_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblparticipentsinmeeting_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblparticipentsinmeeting_id_seq OWNER TO postgres;

--
-- Name: tblparticipentsinmeeting_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblparticipentsinmeeting_id_seq OWNED BY public.tblparticipentsinmeeting.id;


--
-- Name: tblusers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblusers (
    id integer NOT NULL,
    username character varying(20) NOT NULL,
    password character varying(18) NOT NULL,
    firstname character varying(20) NOT NULL,
    lastname character varying(20) NOT NULL,
    gender boolean NOT NULL,
    phone character varying(10) NOT NULL,
    birthday character varying(50) NOT NULL,
    email character varying(50) NOT NULL,
    interests text NOT NULL,
    profpicext character varying(10) NOT NULL,
    usertype integer NOT NULL
);


ALTER TABLE public.tblusers OWNER TO postgres;

--
-- Name: tblusers_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblusers_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblusers_id_seq OWNER TO postgres;

--
-- Name: tblusers_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblusers_id_seq OWNED BY public.tblusers.id;


--
-- Name: tblusertypes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblusertypes (
    id integer NOT NULL,
    name character varying(20) NOT NULL
);


ALTER TABLE public.tblusertypes OWNER TO postgres;

--
-- Name: tblusertypes_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tblusertypes_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tblusertypes_id_seq OWNER TO postgres;

--
-- Name: tblusertypes_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblusertypes_id_seq OWNED BY public.tblusertypes.id;


--
-- Name: tblchats id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats ALTER COLUMN id SET DEFAULT nextval('public.tblchats_id_seq'::regclass);


--
-- Name: tblfriends id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends ALTER COLUMN id SET DEFAULT nextval('public.tblfriends_id_seq'::regclass);


--
-- Name: tblmeetings id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmeetings ALTER COLUMN id SET DEFAULT nextval('public.tblmeetings_id_seq'::regclass);


--
-- Name: tblmessages id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages ALTER COLUMN id SET DEFAULT nextval('public.tblmessages_id_seq'::regclass);


--
-- Name: tblparticipentsinmeeting id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting ALTER COLUMN id SET DEFAULT nextval('public.tblparticipentsinmeeting_id_seq'::regclass);


--
-- Name: tblusers id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusers ALTER COLUMN id SET DEFAULT nextval('public.tblusers_id_seq'::regclass);


--
-- Name: tblusertypes id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusertypes ALTER COLUMN id SET DEFAULT nextval('public.tblusertypes_id_seq'::regclass);


--
-- Data for Name: tblchats; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblchats (id, user1, user2) FROM stdin;
\.
COPY public.tblchats (id, user1, user2) FROM '$$PATH$$/3383.dat';

--
-- Data for Name: tblfriends; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblfriends (id, user1, user2) FROM stdin;
\.
COPY public.tblfriends (id, user1, user2) FROM '$$PATH$$/3381.dat';

--
-- Data for Name: tblmeetings; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblmeetings (id, creator, description, location, name, meetingtime) FROM stdin;
\.
COPY public.tblmeetings (id, creator, description, location, name, meetingtime) FROM '$$PATH$$/3385.dat';

--
-- Data for Name: tblmessages; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblmessages (id, sender, sendingtime, content, chat) FROM stdin;
\.
COPY public.tblmessages (id, sender, sendingtime, content, chat) FROM '$$PATH$$/3387.dat';

--
-- Data for Name: tblparticipentsinmeeting; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblparticipentsinmeeting (id, participent, meeting) FROM stdin;
\.
COPY public.tblparticipentsinmeeting (id, participent, meeting) FROM '$$PATH$$/3389.dat';

--
-- Data for Name: tblusers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblusers (id, username, password, firstname, lastname, gender, phone, birthday, email, interests, profpicext, usertype) FROM stdin;
\.
COPY public.tblusers (id, username, password, firstname, lastname, gender, phone, birthday, email, interests, profpicext, usertype) FROM '$$PATH$$/3379.dat';

--
-- Data for Name: tblusertypes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblusertypes (id, name) FROM stdin;
\.
COPY public.tblusertypes (id, name) FROM '$$PATH$$/3377.dat';

--
-- Name: tblchats_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblchats_id_seq', 8, true);


--
-- Name: tblfriends_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblfriends_id_seq', 6, true);


--
-- Name: tblmeetings_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblmeetings_id_seq', 2, true);


--
-- Name: tblmessages_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblmessages_id_seq', 12, true);


--
-- Name: tblparticipentsinmeeting_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblparticipentsinmeeting_id_seq', 4, true);


--
-- Name: tblusers_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblusers_id_seq', 3, true);


--
-- Name: tblusertypes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblusertypes_id_seq', 1, false);


--
-- Name: tblfriends pk_tblfriends; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT pk_tblfriends PRIMARY KEY (id);


--
-- Name: tblchats tblchats_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_pkey PRIMARY KEY (id);


--
-- Name: tblmeetings tblmeetings_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmeetings
    ADD CONSTRAINT tblmeetings_pkey PRIMARY KEY (id);


--
-- Name: tblmessages tblmessages_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_pkey PRIMARY KEY (id);


--
-- Name: tblparticipentsinmeeting tblparticipentsinmeeting_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_pkey PRIMARY KEY (id);


--
-- Name: tblusers tblusers_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusers
    ADD CONSTRAINT tblusers_pkey PRIMARY KEY (id);


--
-- Name: tblusertypes tblusertypes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusertypes
    ADD CONSTRAINT tblusertypes_pkey PRIMARY KEY (id);


--
-- Name: tblfriends fk_tblfriends_tblusers; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT fk_tblfriends_tblusers FOREIGN KEY (user1) REFERENCES public.tblusers(id);


--
-- Name: tblfriends fk_tblfriends_tblusers1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT fk_tblfriends_tblusers1 FOREIGN KEY (user2) REFERENCES public.tblusers(id);


--
-- Name: tblusers fk_tblusers_tblusertypes; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusers
    ADD CONSTRAINT fk_tblusers_tblusertypes FOREIGN KEY (usertype) REFERENCES public.tblusertypes(id);


--
-- Name: tblchats tblchats_user1_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_user1_fkey FOREIGN KEY (user1) REFERENCES public.tblusers(id);


--
-- Name: tblchats tblchats_user2_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_user2_fkey FOREIGN KEY (user2) REFERENCES public.tblusers(id);


--
-- Name: tblmeetings tblmeetings_creator_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmeetings
    ADD CONSTRAINT tblmeetings_creator_fkey FOREIGN KEY (creator) REFERENCES public.tblusers(id);


--
-- Name: tblmessages tblmessages_chat_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_chat_fkey FOREIGN KEY (chat) REFERENCES public.tblchats(id);


--
-- Name: tblmessages tblmessages_sender_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_sender_fkey FOREIGN KEY (sender) REFERENCES public.tblusers(id);


--
-- Name: tblparticipentsinmeeting tblparticipentsinmeeting_meeting_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_meeting_fkey FOREIGN KEY (meeting) REFERENCES public.tblmeetings(id);


--
-- Name: tblparticipentsinmeeting tblparticipentsinmeeting_participent_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_participent_fkey FOREIGN KEY (participent) REFERENCES public.tblusers(id);


--
-- PostgreSQL database dump complete
--

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 