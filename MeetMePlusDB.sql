--
-- PostgreSQL database dump
--

-- Dumped from database version 15.2
-- Dumped by pg_dump version 15.2

-- Started on 2023-04-10 12:18:05

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
-- TOC entry 221 (class 1259 OID 16438)
-- Name: tblchats; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblchats (
    id integer NOT NULL,
    user1 integer NOT NULL,
    user2 integer NOT NULL
);


ALTER TABLE public.tblchats OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 16437)
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
-- TOC entry 3395 (class 0 OID 0)
-- Dependencies: 220
-- Name: tblchats_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblchats_id_seq OWNED BY public.tblchats.id;


--
-- TOC entry 219 (class 1259 OID 16421)
-- Name: tblfriends; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblfriends (
    id integer NOT NULL,
    user1 integer,
    user2 integer
);


ALTER TABLE public.tblfriends OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 16420)
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
-- TOC entry 3396 (class 0 OID 0)
-- Dependencies: 218
-- Name: tblfriends_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblfriends_id_seq OWNED BY public.tblfriends.id;


--
-- TOC entry 223 (class 1259 OID 16455)
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
-- TOC entry 222 (class 1259 OID 16454)
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
-- TOC entry 3397 (class 0 OID 0)
-- Dependencies: 222
-- Name: tblmeetings_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblmeetings_id_seq OWNED BY public.tblmeetings.id;


--
-- TOC entry 225 (class 1259 OID 16469)
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
-- TOC entry 224 (class 1259 OID 16468)
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
-- TOC entry 3398 (class 0 OID 0)
-- Dependencies: 224
-- Name: tblmessages_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblmessages_id_seq OWNED BY public.tblmessages.id;


--
-- TOC entry 227 (class 1259 OID 16488)
-- Name: tblparticipentsinmeeting; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblparticipentsinmeeting (
    id integer NOT NULL,
    participent integer NOT NULL,
    meeting integer NOT NULL
);


ALTER TABLE public.tblparticipentsinmeeting OWNER TO postgres;

--
-- TOC entry 226 (class 1259 OID 16487)
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
-- TOC entry 3399 (class 0 OID 0)
-- Dependencies: 226
-- Name: tblparticipentsinmeeting_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblparticipentsinmeeting_id_seq OWNED BY public.tblparticipentsinmeeting.id;


--
-- TOC entry 217 (class 1259 OID 16407)
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
-- TOC entry 216 (class 1259 OID 16406)
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
-- TOC entry 3400 (class 0 OID 0)
-- Dependencies: 216
-- Name: tblusers_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblusers_id_seq OWNED BY public.tblusers.id;


--
-- TOC entry 215 (class 1259 OID 16400)
-- Name: tblusertypes; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tblusertypes (
    id integer NOT NULL,
    name character varying(20) NOT NULL
);


ALTER TABLE public.tblusertypes OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 16399)
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
-- TOC entry 3401 (class 0 OID 0)
-- Dependencies: 214
-- Name: tblusertypes_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tblusertypes_id_seq OWNED BY public.tblusertypes.id;


--
-- TOC entry 3206 (class 2604 OID 16441)
-- Name: tblchats id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats ALTER COLUMN id SET DEFAULT nextval('public.tblchats_id_seq'::regclass);


--
-- TOC entry 3205 (class 2604 OID 16424)
-- Name: tblfriends id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends ALTER COLUMN id SET DEFAULT nextval('public.tblfriends_id_seq'::regclass);


--
-- TOC entry 3207 (class 2604 OID 16458)
-- Name: tblmeetings id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmeetings ALTER COLUMN id SET DEFAULT nextval('public.tblmeetings_id_seq'::regclass);


--
-- TOC entry 3208 (class 2604 OID 16472)
-- Name: tblmessages id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages ALTER COLUMN id SET DEFAULT nextval('public.tblmessages_id_seq'::regclass);


--
-- TOC entry 3209 (class 2604 OID 16491)
-- Name: tblparticipentsinmeeting id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting ALTER COLUMN id SET DEFAULT nextval('public.tblparticipentsinmeeting_id_seq'::regclass);


--
-- TOC entry 3204 (class 2604 OID 16410)
-- Name: tblusers id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusers ALTER COLUMN id SET DEFAULT nextval('public.tblusers_id_seq'::regclass);


--
-- TOC entry 3203 (class 2604 OID 16403)
-- Name: tblusertypes id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusertypes ALTER COLUMN id SET DEFAULT nextval('public.tblusertypes_id_seq'::regclass);


--
-- TOC entry 3383 (class 0 OID 16438)
-- Dependencies: 221
-- Data for Name: tblchats; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblchats (id, user1, user2) FROM stdin;
2	3	15
3	3	13
8	14	3
\.


--
-- TOC entry 3381 (class 0 OID 16421)
-- Dependencies: 219
-- Data for Name: tblfriends; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblfriends (id, user1, user2) FROM stdin;
25	1	13
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


--
-- TOC entry 3385 (class 0 OID 16455)
-- Dependencies: 223
-- Data for Name: tblmeetings; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblmeetings (id, creator, description, location, name, meetingtime) FROM stdin;
8	9	come and shop with me I'm lonely	Ice Mall	Shopping	07/04/2022 20:00
11	12	Just a testing, doesn't really matter what I write	Zoom	Test meeting #1	09/05/2022 00:00
12	13	Batch Batch Batch Batch Batch Batch Batch	Batch	Batch	17/05/2022 12:00
14	14	Hi! I just joined the app, I would like to test it by making an interesting meeting. Come join me!	Kinamon 14	Just joined	28/05/2022 14:00
1	3	Come watch Titanic with me	Sirpad 11	Watch Titanic	10/04/2023 21:43
2	1	Check	Check	Check	17/04/2023 12:49
\.


--
-- TOC entry 3387 (class 0 OID 16469)
-- Dependencies: 225
-- Data for Name: tblmessages; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblmessages (id, sender, sendingtime, content, chat) FROM stdin;
3	3	2023-04-10 11:23:57.994804	Dorinn come to Eilat	2
4	3	2023-04-10 11:24:30.794657	It's so hot we can go in the pool	2
5	3	2023-04-10 11:24:36.390759	or go to the sea	2
6	3	2023-04-10 11:24:44.278541	So you coming?	2
7	3	2023-04-10 11:24:57.177524	Dad what's up?	3
\.


--
-- TOC entry 3389 (class 0 OID 16488)
-- Dependencies: 227
-- Data for Name: tblparticipentsinmeeting; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblparticipentsinmeeting (id, participent, meeting) FROM stdin;
22	13	11
23	1	14
25	1	8
1	3	12
2	3	11
3	3	14
4	1	11
\.


--
-- TOC entry 3379 (class 0 OID 16407)
-- Dependencies: 217
-- Data for Name: tblusers; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblusers (id, username, password, firstname, lastname, gender, phone, birthday, email, interests, profpicext, usertype) FROM stdin;
9	ShiraYa	Sh1ra	Shira	Yarhi	f	1234567892	Nov 11 2003 12:00AM	Shiraya@gmail.com	Reading,Fishing,Crafting,Yoga,Hiking,Cooking	.jpg	2
12	YuvalYa5	YuvalYa5	Yuval	Yarhi	t	0507625050	Aug 25 2002 12:00AM	yarhiyuval94@gmail.com	Traveling,Hiking,Listening to music,Yoga,Bird Watching	.jpg	2
14	galTzarfati	Gg123456	Gal	Tzarfati	f	0527275418	Jul 7 1990 12:00AM	Tzarfati.Gal@gmail.com	Reading,Traveling,Watching TV,Cooking	.jpg	2
15	DorinT	DorinT	Dorin	Talmoud	f	0536985415	Feb  7 1990 12:00AM	Dorin.Talmoud@gmail.com	Reading,Traveling,Hiking,Cooking	.jpg	2
3	NivZar	NivZar	Niv	Zarfati	t	0524292644	1993-10-30 00:00:00	niv.zar@gmail.com	Traveling,Watching TV,Video Games,Listening to music,Cooking	.jpg	2
13	earonc	Az050565	Aharon	Zarfati	t	0537512354	May  5 1965 12:00AM	earonc@walla.com	Traveling,Crafting,Watching TV,Listening to music	.jpg	2
1	shahar015	Sz05056565!	Shahar	Zarfati	t	0526770488	2004-08-01 00:00:00	shahar0151@gmail.com	Traveling,Watching TV,Listening to music,Video Games,Cooking	.jpg	1
\.


--
-- TOC entry 3377 (class 0 OID 16400)
-- Dependencies: 215
-- Data for Name: tblusertypes; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tblusertypes (id, name) FROM stdin;
1	Admin
2	User
\.


--
-- TOC entry 3402 (class 0 OID 0)
-- Dependencies: 220
-- Name: tblchats_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblchats_id_seq', 8, true);


--
-- TOC entry 3403 (class 0 OID 0)
-- Dependencies: 218
-- Name: tblfriends_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblfriends_id_seq', 6, true);


--
-- TOC entry 3404 (class 0 OID 0)
-- Dependencies: 222
-- Name: tblmeetings_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblmeetings_id_seq', 2, true);


--
-- TOC entry 3405 (class 0 OID 0)
-- Dependencies: 224
-- Name: tblmessages_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblmessages_id_seq', 12, true);


--
-- TOC entry 3406 (class 0 OID 0)
-- Dependencies: 226
-- Name: tblparticipentsinmeeting_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblparticipentsinmeeting_id_seq', 4, true);


--
-- TOC entry 3407 (class 0 OID 0)
-- Dependencies: 216
-- Name: tblusers_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblusers_id_seq', 3, true);


--
-- TOC entry 3408 (class 0 OID 0)
-- Dependencies: 214
-- Name: tblusertypes_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tblusertypes_id_seq', 1, false);


--
-- TOC entry 3215 (class 2606 OID 16426)
-- Name: tblfriends pk_tblfriends; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT pk_tblfriends PRIMARY KEY (id);


--
-- TOC entry 3217 (class 2606 OID 16443)
-- Name: tblchats tblchats_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_pkey PRIMARY KEY (id);


--
-- TOC entry 3219 (class 2606 OID 16462)
-- Name: tblmeetings tblmeetings_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmeetings
    ADD CONSTRAINT tblmeetings_pkey PRIMARY KEY (id);


--
-- TOC entry 3221 (class 2606 OID 16476)
-- Name: tblmessages tblmessages_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_pkey PRIMARY KEY (id);


--
-- TOC entry 3223 (class 2606 OID 16493)
-- Name: tblparticipentsinmeeting tblparticipentsinmeeting_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_pkey PRIMARY KEY (id);


--
-- TOC entry 3213 (class 2606 OID 16414)
-- Name: tblusers tblusers_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusers
    ADD CONSTRAINT tblusers_pkey PRIMARY KEY (id);


--
-- TOC entry 3211 (class 2606 OID 16405)
-- Name: tblusertypes tblusertypes_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusertypes
    ADD CONSTRAINT tblusertypes_pkey PRIMARY KEY (id);


--
-- TOC entry 3225 (class 2606 OID 16427)
-- Name: tblfriends fk_tblfriends_tblusers; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT fk_tblfriends_tblusers FOREIGN KEY (user1) REFERENCES public.tblusers(id);


--
-- TOC entry 3226 (class 2606 OID 16432)
-- Name: tblfriends fk_tblfriends_tblusers1; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblfriends
    ADD CONSTRAINT fk_tblfriends_tblusers1 FOREIGN KEY (user2) REFERENCES public.tblusers(id);


--
-- TOC entry 3224 (class 2606 OID 16415)
-- Name: tblusers fk_tblusers_tblusertypes; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblusers
    ADD CONSTRAINT fk_tblusers_tblusertypes FOREIGN KEY (usertype) REFERENCES public.tblusertypes(id);


--
-- TOC entry 3227 (class 2606 OID 16444)
-- Name: tblchats tblchats_user1_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_user1_fkey FOREIGN KEY (user1) REFERENCES public.tblusers(id);


--
-- TOC entry 3228 (class 2606 OID 16449)
-- Name: tblchats tblchats_user2_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblchats
    ADD CONSTRAINT tblchats_user2_fkey FOREIGN KEY (user2) REFERENCES public.tblusers(id);


--
-- TOC entry 3229 (class 2606 OID 16463)
-- Name: tblmeetings tblmeetings_creator_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmeetings
    ADD CONSTRAINT tblmeetings_creator_fkey FOREIGN KEY (creator) REFERENCES public.tblusers(id);


--
-- TOC entry 3230 (class 2606 OID 16482)
-- Name: tblmessages tblmessages_chat_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_chat_fkey FOREIGN KEY (chat) REFERENCES public.tblchats(id);


--
-- TOC entry 3231 (class 2606 OID 16477)
-- Name: tblmessages tblmessages_sender_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblmessages
    ADD CONSTRAINT tblmessages_sender_fkey FOREIGN KEY (sender) REFERENCES public.tblusers(id);


--
-- TOC entry 3232 (class 2606 OID 16499)
-- Name: tblparticipentsinmeeting tblparticipentsinmeeting_meeting_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_meeting_fkey FOREIGN KEY (meeting) REFERENCES public.tblmeetings(id);


--
-- TOC entry 3233 (class 2606 OID 16494)
-- Name: tblparticipentsinmeeting tblparticipentsinmeeting_participent_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tblparticipentsinmeeting
    ADD CONSTRAINT tblparticipentsinmeeting_participent_fkey FOREIGN KEY (participent) REFERENCES public.tblusers(id);


-- Completed on 2023-04-10 12:18:05

--
-- PostgreSQL database dump complete
--

