--
-- PostgreSQL database dump
--

-- Dumped from database version 12.1
-- Dumped by pg_dump version 12rc1

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
-- Name: Answer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Answer" (
    "Id" integer NOT NULL,
    "AnswerStateId" integer NOT NULL,
    "QuesId" integer NOT NULL,
    "DeleteDate" date,
    "CreateDate" date
);


ALTER TABLE public."Answer" OWNER TO postgres;

--
-- Name: AnswerState; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."AnswerState" (
    "Id" integer NOT NULL,
    "Satet" integer,
    "Description" character varying(250)
);


ALTER TABLE public."AnswerState" OWNER TO postgres;

--
-- Name: Category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Category" (
    "Id" integer NOT NULL,
    "Name" character varying(100)
);


ALTER TABLE public."Category" OWNER TO postgres;

--
-- Name: Commet; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Commet" (
    "Id" integer NOT NULL,
    "QuesId" integer NOT NULL,
    "UserId" integer NOT NULL,
    "Text" character varying(100),
    "Date" date
);


ALTER TABLE public."Commet" OWNER TO postgres;

--
-- Name: GeriDonus; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."GeriDonus" (
    "Id" integer NOT NULL,
    "QuesId" integer NOT NULL,
    "CreateDate" date
);


ALTER TABLE public."GeriDonus" OWNER TO postgres;

--
-- Name: Question; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Question" (
    "Id" integer NOT NULL,
    "CategoryId" integer NOT NULL,
    "UserId" integer NOT NULL,
    "CreateDate" date,
    "ViewCount" integer,
    "Icerik" character varying(100),
    "Head" character varying(100),
    "AnswerCount" integer
);


ALTER TABLE public."Question" OWNER TO postgres;

--
-- Name: Role; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Role" (
    "Id" integer NOT NULL,
    "Name" character varying(2044),
    "Description" character varying(2044)
);


ALTER TABLE public."Role" OWNER TO postgres;

--
-- Name: Role_User; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Role_User" (
    "RoleId" integer NOT NULL,
    "UserId" integer NOT NULL
);


ALTER TABLE public."Role_User" OWNER TO postgres;

--
-- Name: Rozet; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Rozet" (
    "Id" integer NOT NULL,
    "UserId" integer NOT NULL
);


ALTER TABLE public."Rozet" OWNER TO postgres;

--
-- Name: RozetLine; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."RozetLine" (
    "Id" integer NOT NULL,
    "RozetTıpId" integer NOT NULL,
    "ROzetId" integer NOT NULL,
    "Count" integer
);


ALTER TABLE public."RozetLine" OWNER TO postgres;

--
-- Name: RozetTipi; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."RozetTipi" (
    "Id" integer NOT NULL,
    "Name" character varying(2044)
);


ALTER TABLE public."RozetTipi" OWNER TO postgres;

--
-- Name: Rozet_Tag; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Rozet_Tag" (
    "RSatirId" integer NOT NULL,
    "TagsId" integer NOT NULL
);


ALTER TABLE public."Rozet_Tag" OWNER TO postgres;

--
-- Name: S_Oylar; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."S_Oylar" (
    "Id" integer NOT NULL,
    "AnswerId" integer NOT NULL,
    "UserId" integer NOT NULL,
    "GeriDonusId" integer NOT NULL,
    "Puan" integer
);


ALTER TABLE public."S_Oylar" OWNER TO postgres;

--
-- Name: Tags; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Tags" (
    "Id" integer NOT NULL,
    "TagAdi" character varying(2044),
    "Counter" integer
);


ALTER TABLE public."Tags" OWNER TO postgres;

--
-- Name: Tags_Ques; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Tags_Ques" (
    "SoruId" integer NOT NULL,
    "TagsId" integer NOT NULL
);


ALTER TABLE public."Tags_Ques" OWNER TO postgres;

--
-- Name: User; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."User" (
    "Id" integer NOT NULL,
    "DisplayName" character varying(2044),
    "Email" character varying(2044),
    "Password" character varying(2044),
    "AnswerCount" integer,
    "QuesCount" integer
);


ALTER TABLE public."User" OWNER TO postgres;

--
-- Data for Name: Answer; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Answer" VALUES (1, 1, 1, '2019-11-30', '2019-11-30');
INSERT INTO public."Answer" VALUES (2, 2, 2, NULL, '2019-11-30');


--
-- Data for Name: AnswerState; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."AnswerState" VALUES (2, 0, 'onaylanmadı');
INSERT INTO public."AnswerState" VALUES (1, 1, 'onaylandı');


--
-- Data for Name: Category; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Category" VALUES (1, 'Postresql');
INSERT INTO public."Category" VALUES (2, 'Java');


--
-- Data for Name: Commet; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Commet" VALUES (1, 1, 1, 'dneme deneme', '2019-11-30');
INSERT INTO public."Commet" VALUES (2, 2, 2, 'deneme', '2019-11-30');


--
-- Data for Name: GeriDonus; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."GeriDonus" VALUES (1, 1, '2019-11-30');
INSERT INTO public."GeriDonus" VALUES (2, 2, '2019-11-30');


--
-- Data for Name: Question; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Question" VALUES (1, 1, 2, '2019-11-30', 5, 'how to doing', 'postresql', 100);
INSERT INTO public."Question" VALUES (2, 1, 2, '2019-11-30', 200, 'how to doing', 'Java', 50);


--
-- Data for Name: Role; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Role" VALUES (1, 'admin', 'Gelistirici');
INSERT INTO public."Role" VALUES (2, 'user', 'Kullanici');


--
-- Data for Name: Role_User; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Role_User" VALUES (1, 1);
INSERT INTO public."Role_User" VALUES (2, 2);


--
-- Data for Name: Rozet; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Rozet" VALUES (1, 2);
INSERT INTO public."Rozet" VALUES (2, 2);


--
-- Data for Name: RozetLine; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."RozetLine" VALUES (1, 1, 1, 123);
INSERT INTO public."RozetLine" VALUES (2, 2, 2, 2324);


--
-- Data for Name: RozetTipi; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."RozetTipi" VALUES (1, 'altın');
INSERT INTO public."RozetTipi" VALUES (2, 'bronz');


--
-- Data for Name: Rozet_Tag; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Rozet_Tag" VALUES (1, 2);
INSERT INTO public."Rozet_Tag" VALUES (2, 1);


--
-- Data for Name: S_Oylar; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."S_Oylar" VALUES (1, 1, 1, 1, 1213);
INSERT INTO public."S_Oylar" VALUES (2, 2, 2, 2, 124);


--
-- Data for Name: Tags; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Tags" VALUES (1, 'deneme', 33);
INSERT INTO public."Tags" VALUES (2, 'deneme', 45825);


--
-- Data for Name: Tags_Ques; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Tags_Ques" VALUES (1, 2);
INSERT INTO public."Tags_Ques" VALUES (2, 1);


--
-- Data for Name: User; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."User" VALUES (1, 'yunussen', 'yunussen@gmail.com', '123456a', 5, 100);
INSERT INTO public."User" VALUES (2, 'deneme', 'deneme@gmail.com', '123456', 1, 1);


--
-- Name: AnswerState AnswerState_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."AnswerState"
    ADD CONSTRAINT "AnswerState_pkey" PRIMARY KEY ("Id");


--
-- Name: Answer Answer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Answer"
    ADD CONSTRAINT "Answer_pkey" PRIMARY KEY ("Id");


--
-- Name: Category Category_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Category"
    ADD CONSTRAINT "Category_pkey" PRIMARY KEY ("Id");


--
-- Name: Commet Commet_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Commet"
    ADD CONSTRAINT "Commet_pkey" PRIMARY KEY ("Id");


--
-- Name: GeriDonus GeriDonus_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."GeriDonus"
    ADD CONSTRAINT "GeriDonus_pkey" PRIMARY KEY ("Id");


--
-- Name: Question Question_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Question"
    ADD CONSTRAINT "Question_pkey" PRIMARY KEY ("Id");


--
-- Name: Role Role_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Role"
    ADD CONSTRAINT "Role_pkey" PRIMARY KEY ("Id");


--
-- Name: RozetLine RozetLine_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."RozetLine"
    ADD CONSTRAINT "RozetLine_pkey" PRIMARY KEY ("Id");


--
-- Name: RozetTipi RozetTipi_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."RozetTipi"
    ADD CONSTRAINT "RozetTipi_pkey" PRIMARY KEY ("Id");


--
-- Name: Rozet Rozet_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Rozet"
    ADD CONSTRAINT "Rozet_pkey" PRIMARY KEY ("Id");


--
-- Name: S_Oylar S_Oylar_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."S_Oylar"
    ADD CONSTRAINT "S_Oylar_pkey" PRIMARY KEY ("Id");


--
-- Name: Tags Tags_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Tags"
    ADD CONSTRAINT "Tags_pkey" PRIMARY KEY ("Id");


--
-- Name: User User_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY ("Id");


--
-- Name: Answer lnk_AnswerState_Answer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Answer"
    ADD CONSTRAINT "lnk_AnswerState_Answer" FOREIGN KEY ("AnswerStateId") REFERENCES public."AnswerState"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: GeriDonus lnk_Answer_GeriDonus; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."GeriDonus"
    ADD CONSTRAINT "lnk_Answer_GeriDonus" FOREIGN KEY ("QuesId") REFERENCES public."Answer"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: S_Oylar lnk_Answer_S_Oylar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."S_Oylar"
    ADD CONSTRAINT "lnk_Answer_S_Oylar" FOREIGN KEY ("AnswerId") REFERENCES public."Answer"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Question lnk_Category_Question; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Question"
    ADD CONSTRAINT "lnk_Category_Question" FOREIGN KEY ("CategoryId") REFERENCES public."Category"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: S_Oylar lnk_GeriDonus_S_Oylar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."S_Oylar"
    ADD CONSTRAINT "lnk_GeriDonus_S_Oylar" FOREIGN KEY ("GeriDonusId") REFERENCES public."GeriDonus"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Answer lnk_Question_Answer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Answer"
    ADD CONSTRAINT "lnk_Question_Answer" FOREIGN KEY ("QuesId") REFERENCES public."Question"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Commet lnk_Question_Commet; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Commet"
    ADD CONSTRAINT "lnk_Question_Commet" FOREIGN KEY ("QuesId") REFERENCES public."Question"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Tags_Ques lnk_Question_Tags_Ques; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Tags_Ques"
    ADD CONSTRAINT "lnk_Question_Tags_Ques" FOREIGN KEY ("SoruId") REFERENCES public."Question"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Role_User lnk_Role_Role_User; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Role_User"
    ADD CONSTRAINT "lnk_Role_Role_User" FOREIGN KEY ("RoleId") REFERENCES public."Role"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Rozet_Tag lnk_RozetLine_Rozet_Tag; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Rozet_Tag"
    ADD CONSTRAINT "lnk_RozetLine_Rozet_Tag" FOREIGN KEY ("RSatirId") REFERENCES public."RozetLine"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: RozetLine lnk_RozetTipi_RozetLine; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."RozetLine"
    ADD CONSTRAINT "lnk_RozetTipi_RozetLine" FOREIGN KEY ("RozetTıpId") REFERENCES public."RozetTipi"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: RozetLine lnk_Rozet_RozetLine; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."RozetLine"
    ADD CONSTRAINT "lnk_Rozet_RozetLine" FOREIGN KEY ("ROzetId") REFERENCES public."Rozet"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Rozet_Tag lnk_Tags_Rozet_Tag; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Rozet_Tag"
    ADD CONSTRAINT "lnk_Tags_Rozet_Tag" FOREIGN KEY ("TagsId") REFERENCES public."Tags"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Tags_Ques lnk_Tags_Tags_Ques; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Tags_Ques"
    ADD CONSTRAINT "lnk_Tags_Tags_Ques" FOREIGN KEY ("TagsId") REFERENCES public."Tags"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Commet lnk_User_Commet; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Commet"
    ADD CONSTRAINT "lnk_User_Commet" FOREIGN KEY ("UserId") REFERENCES public."User"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Question lnk_User_Question; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Question"
    ADD CONSTRAINT "lnk_User_Question" FOREIGN KEY ("UserId") REFERENCES public."User"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Role_User lnk_User_Role_User; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Role_User"
    ADD CONSTRAINT "lnk_User_Role_User" FOREIGN KEY ("UserId") REFERENCES public."User"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Rozet lnk_User_Rozet; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Rozet"
    ADD CONSTRAINT "lnk_User_Rozet" FOREIGN KEY ("UserId") REFERENCES public."User"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: S_Oylar lnk_User_S_Oylar; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."S_Oylar"
    ADD CONSTRAINT "lnk_User_S_Oylar" FOREIGN KEY ("UserId") REFERENCES public."User"("Id") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

