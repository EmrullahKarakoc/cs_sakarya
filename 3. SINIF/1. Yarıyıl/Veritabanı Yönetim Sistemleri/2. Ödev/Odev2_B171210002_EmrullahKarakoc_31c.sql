--
-- PostgreSQL database dump
--

-- Dumped from database version 12.0
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
-- Name: ADMIN; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."ADMIN" (
    "ID" integer NOT NULL,
    "KatilmaTarihi" date NOT NULL,
    "Departmani" character varying(2044) NOT NULL
);


ALTER TABLE public."ADMIN" OWNER TO postgres;

--
-- Name: Answer; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Answer" (
    "ID" integer NOT NULL,
    "QuestionsID" integer NOT NULL,
    "UserID" integer NOT NULL,
    "CevapIcerigi" text NOT NULL,
    "CevapTarihi" date NOT NULL
);


ALTER TABLE public."Answer" OWNER TO postgres;

--
-- Name: Badges; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Badges" (
    "BadgesID" integer NOT NULL,
    "RozetIsmi" character varying(2044) NOT NULL,
    "RozetPuani" integer NOT NULL
);


ALTER TABLE public."Badges" OWNER TO postgres;

--
-- Name: BadgesCategories; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."BadgesCategories" (
    "ID" integer NOT NULL,
    "BadgesID" integer NOT NULL,
    "KategoriIsmi" character varying(2044) NOT NULL
);


ALTER TABLE public."BadgesCategories" OWNER TO postgres;

--
-- Name: Community; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Community" (
    "CommunityID" integer NOT NULL,
    "ToplulukIsmı" character varying(2044) NOT NULL,
    "ToplulukSorumlusu" character varying(2044) NOT NULL,
    "ToplulukBaskani" character varying(2044) NOT NULL
);


ALTER TABLE public."Community" OWNER TO postgres;

--
-- Name: Messages; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Messages" (
    "ID" integer NOT NULL,
    "UserID" integer NOT NULL,
    "MesajIcerıgı" text NOT NULL,
    "MesajBasligi" text NOT NULL,
    "MesajKonusu" text NOT NULL
);


ALTER TABLE public."Messages" OWNER TO postgres;

--
-- Name: NORMALUSER; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."NORMALUSER" (
    "ID" integer NOT NULL,
    "KatilmaTarihi" date NOT NULL
);


ALTER TABLE public."NORMALUSER" OWNER TO postgres;

--
-- Name: Questions; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Questions" (
    "QuestionsID" integer NOT NULL,
    "UserID" integer NOT NULL,
    "SoruBasligi" text NOT NULL,
    "SorulmaZamani" date NOT NULL,
    "SoruIcerıgı" text NOT NULL
);


ALTER TABLE public."Questions" OWNER TO postgres;

--
-- Name: QuestionsDurumu; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."QuestionsDurumu" (
    "ID" integer NOT NULL,
    "QuestıonsID" integer NOT NULL,
    "QuestıonsDurumu" integer NOT NULL
);


ALTER TABLE public."QuestionsDurumu" OWNER TO postgres;

--
-- Name: QuestionsTag; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."QuestionsTag" (
    "ID" integer NOT NULL,
    "QuestionsID" integer NOT NULL,
    "TagsID" integer NOT NULL
);


ALTER TABLE public."QuestionsTag" OWNER TO postgres;

--
-- Name: SUPERADMİN; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."SUPERADMİN" (
    "ID" integer NOT NULL,
    "KatilmaTarihi" date NOT NULL
);


ALTER TABLE public."SUPERADMİN" OWNER TO postgres;

--
-- Name: SoruKategori; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."SoruKategori" (
    "ID" integer NOT NULL,
    "QuestıonsID" integer NOT NULL,
    "KategoriIsmi" character varying(2044) NOT NULL
);


ALTER TABLE public."SoruKategori" OWNER TO postgres;

--
-- Name: Tags; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Tags" (
    "TagsID" integer NOT NULL,
    "TagNama" character varying(2044) NOT NULL
);


ALTER TABLE public."Tags" OWNER TO postgres;

--
-- Name: User; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."User" (
    "UserID" integer NOT NULL,
    "UserName" character varying(2044) NOT NULL,
    "UserPassword" character varying(2044) NOT NULL,
    "UserMail" character varying(2044) NOT NULL,
    "UserTelephone" character varying(2044) NOT NULL,
    "RozetPuani" integer NOT NULL,
    "UserTuru" character varying(2044) NOT NULL
);


ALTER TABLE public."User" OWNER TO postgres;

--
-- Name: UserBadges; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."UserBadges" (
    "ID" integer NOT NULL,
    "BadgesID" integer NOT NULL,
    "UserID" integer NOT NULL
);


ALTER TABLE public."UserBadges" OWNER TO postgres;

--
-- Name: UserCommunity; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."UserCommunity" (
    "ID" integer NOT NULL,
    "UserID" integer NOT NULL,
    "CommunıtyID" integer NOT NULL
);


ALTER TABLE public."UserCommunity" OWNER TO postgres;

--
-- Data for Name: ADMIN; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."ADMIN" VALUES (2, '2019-11-30', 'topluluklar');


--
-- Data for Name: Answer; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Answer" VALUES (1, 2, 1, 'array boyle olur', '2019-11-30');


--
-- Data for Name: Badges; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Badges" VALUES (3, 'kurnaz', 50);
INSERT INTO public."Badges" VALUES (2, 'avci', 55);
INSERT INTO public."Badges" VALUES (1, 'basarili', 70);


--
-- Data for Name: BadgesCategories; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Community; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Community" VALUES (1, 'btsakarya', 'celal ceken', 'emrullah karakoc');


--
-- Data for Name: Messages; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Messages" VALUES (1, 1, 'selam', 'karsilama', 'merhaba');
INSERT INTO public."Messages" VALUES (2, 2, 'nasilsiniz', 'karşılama2', 'karsilama');


--
-- Data for Name: NORMALUSER; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: Questions; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Questions" VALUES (1, 1, 'nasil boyle olur ?', '2019-11-30', 'c# dosya islemleri');
INSERT INTO public."Questions" VALUES (2, 2, 'bunu nasil yapabilirim ?', '2019-11-30', 'c++ array');


--
-- Data for Name: QuestionsDurumu; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."QuestionsDurumu" VALUES (1, 1, 1);


--
-- Data for Name: QuestionsTag; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."QuestionsTag" VALUES (1, 1, 1);
INSERT INTO public."QuestionsTag" VALUES (2, 2, 1);


--
-- Data for Name: SUPERADMİN; Type: TABLE DATA; Schema: public; Owner: postgres
--



--
-- Data for Name: SoruKategori; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."SoruKategori" VALUES (1, 1, 'C++');
INSERT INTO public."SoruKategori" VALUES (2, 1, 'c#');


--
-- Data for Name: Tags; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."Tags" VALUES (1, 'c++');
INSERT INTO public."Tags" VALUES (2, 'c#');


--
-- Data for Name: User; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."User" VALUES (1, 'Emrullah', '123', 'karakooc24@gmail.com', '05368360669', 69, '1');
INSERT INTO public."User" VALUES (2, 'Nurullah', '123', 'nurullah@gmail.com', '05533525137', 70, '1');
INSERT INTO public."User" VALUES (3, 'Yunus', '123', 'yunus@gmail.com', '05555555555', 27, '2');


--
-- Data for Name: UserBadges; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."UserBadges" VALUES (1, 1, 1);
INSERT INTO public."UserBadges" VALUES (2, 1, 2);
INSERT INTO public."UserBadges" VALUES (3, 2, 3);
INSERT INTO public."UserBadges" VALUES (4, 3, 1);


--
-- Data for Name: UserCommunity; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public."UserCommunity" VALUES (1, 1, 1);
INSERT INTO public."UserCommunity" VALUES (2, 2, 1);


--
-- Name: ADMIN ADMIN_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ADMIN"
    ADD CONSTRAINT "ADMIN_pkey" PRIMARY KEY ("ID");


--
-- Name: Answer Answer_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Answer"
    ADD CONSTRAINT "Answer_pkey" PRIMARY KEY ("ID");


--
-- Name: BadgesCategories BadgesCategories_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."BadgesCategories"
    ADD CONSTRAINT "BadgesCategories_pkey" PRIMARY KEY ("ID");


--
-- Name: Badges Badges_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Badges"
    ADD CONSTRAINT "Badges_pkey" PRIMARY KEY ("BadgesID");


--
-- Name: Community Community_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Community"
    ADD CONSTRAINT "Community_pkey" PRIMARY KEY ("CommunityID");


--
-- Name: Messages Messages_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Messages"
    ADD CONSTRAINT "Messages_pkey" PRIMARY KEY ("ID");


--
-- Name: NORMALUSER NORMALUSER_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."NORMALUSER"
    ADD CONSTRAINT "NORMALUSER_pkey" PRIMARY KEY ("ID");


--
-- Name: QuestionsDurumu QuestionsDurumu_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."QuestionsDurumu"
    ADD CONSTRAINT "QuestionsDurumu_pkey" PRIMARY KEY ("ID");


--
-- Name: QuestionsTag QuestionsTag_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."QuestionsTag"
    ADD CONSTRAINT "QuestionsTag_pkey" PRIMARY KEY ("ID");


--
-- Name: Questions Questions_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Questions"
    ADD CONSTRAINT "Questions_pkey" PRIMARY KEY ("QuestionsID");


--
-- Name: SUPERADMİN SUPERADMİN_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SUPERADMİN"
    ADD CONSTRAINT "SUPERADMİN_pkey" PRIMARY KEY ("ID");


--
-- Name: SoruKategori SoruKategori_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SoruKategori"
    ADD CONSTRAINT "SoruKategori_pkey" PRIMARY KEY ("ID");


--
-- Name: Tags Tags_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Tags"
    ADD CONSTRAINT "Tags_pkey" PRIMARY KEY ("TagsID");


--
-- Name: UserBadges UserBadges_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."UserBadges"
    ADD CONSTRAINT "UserBadges_pkey" PRIMARY KEY ("ID");


--
-- Name: UserCommunity UserCommunity_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."UserCommunity"
    ADD CONSTRAINT "UserCommunity_pkey" PRIMARY KEY ("ID");


--
-- Name: User User_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."User"
    ADD CONSTRAINT "User_pkey" PRIMARY KEY ("UserID");


--
-- Name: BadgesCategories lnk_Badges_BadgesCategories; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."BadgesCategories"
    ADD CONSTRAINT "lnk_Badges_BadgesCategories" FOREIGN KEY ("BadgesID") REFERENCES public."Badges"("BadgesID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: UserBadges lnk_Badges_UserBadges; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."UserBadges"
    ADD CONSTRAINT "lnk_Badges_UserBadges" FOREIGN KEY ("BadgesID") REFERENCES public."Badges"("BadgesID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: UserCommunity lnk_Community_UserCommunity; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."UserCommunity"
    ADD CONSTRAINT "lnk_Community_UserCommunity" FOREIGN KEY ("CommunıtyID") REFERENCES public."Community"("CommunityID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Answer lnk_Questions_Answer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Answer"
    ADD CONSTRAINT "lnk_Questions_Answer" FOREIGN KEY ("QuestionsID") REFERENCES public."Questions"("QuestionsID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: QuestionsDurumu lnk_Questions_QuestionsDurumu; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."QuestionsDurumu"
    ADD CONSTRAINT "lnk_Questions_QuestionsDurumu" FOREIGN KEY ("QuestıonsID") REFERENCES public."Questions"("QuestionsID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: QuestionsTag lnk_Questions_QuestionsTag; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."QuestionsTag"
    ADD CONSTRAINT "lnk_Questions_QuestionsTag" FOREIGN KEY ("QuestionsID") REFERENCES public."Questions"("QuestionsID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: SoruKategori lnk_Questions_SoruKategori; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SoruKategori"
    ADD CONSTRAINT "lnk_Questions_SoruKategori" FOREIGN KEY ("QuestıonsID") REFERENCES public."Questions"("QuestionsID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: QuestionsTag lnk_Tags_QuestionsTag; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."QuestionsTag"
    ADD CONSTRAINT "lnk_Tags_QuestionsTag" FOREIGN KEY ("TagsID") REFERENCES public."Tags"("TagsID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: ADMIN lnk_User_ADMIN; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."ADMIN"
    ADD CONSTRAINT "lnk_User_ADMIN" FOREIGN KEY ("ID") REFERENCES public."User"("UserID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Answer lnk_User_Answer; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Answer"
    ADD CONSTRAINT "lnk_User_Answer" FOREIGN KEY ("UserID") REFERENCES public."User"("UserID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: Messages lnk_User_Messages; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Messages"
    ADD CONSTRAINT "lnk_User_Messages" FOREIGN KEY ("UserID") REFERENCES public."User"("UserID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: NORMALUSER lnk_User_NORMALUSER; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."NORMALUSER"
    ADD CONSTRAINT "lnk_User_NORMALUSER" FOREIGN KEY ("ID") REFERENCES public."User"("UserID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: SUPERADMİN lnk_User_SUPERADMİN; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."SUPERADMİN"
    ADD CONSTRAINT "lnk_User_SUPERADMİN" FOREIGN KEY ("ID") REFERENCES public."User"("UserID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: UserBadges lnk_User_UserBadges; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."UserBadges"
    ADD CONSTRAINT "lnk_User_UserBadges" FOREIGN KEY ("UserID") REFERENCES public."User"("UserID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- Name: UserCommunity lnk_User_UserCommunity; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."UserCommunity"
    ADD CONSTRAINT "lnk_User_UserCommunity" FOREIGN KEY ("UserID") REFERENCES public."User"("UserID") MATCH FULL ON UPDATE CASCADE ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--

