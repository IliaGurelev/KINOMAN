--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.0

-- Started on 2024-03-11 10:48:14

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
-- TOC entry 218 (class 1259 OID 16470)
-- Name: favorite_movie; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.favorite_movie (
    id character varying NOT NULL,
    id_movie character varying,
    id_user character varying
);


ALTER TABLE public.favorite_movie OWNER TO postgres;

--
-- TOC entry 217 (class 1259 OID 16457)
-- Name: icons; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.icons (
    id integer NOT NULL,
    image_url character varying
);


ALTER TABLE public.icons OWNER TO postgres;

--
-- TOC entry 215 (class 1259 OID 16397)
-- Name: movie; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.movie (
    id character varying NOT NULL,
    name character varying,
    description character varying(600),
    image_url character varying
);


ALTER TABLE public.movie OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 16410)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id character varying NOT NULL,
    logins character varying,
    passwords character varying,
    icon integer DEFAULT 1
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 219 (class 1259 OID 16495)
-- Name: watched_movie; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.watched_movie (
    id character varying NOT NULL,
    id_movie character varying,
    id_user character varying
);


ALTER TABLE public.watched_movie OWNER TO postgres;

--
-- TOC entry 4813 (class 0 OID 16470)
-- Dependencies: 218
-- Data for Name: favorite_movie; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.favorite_movie (id, id_movie, id_user) FROM stdin;
5ab46aeb-2c30-4d1e-85cf-d63025ebb98a	2	2
f092c64f-a2aa-4e27-824f-7b5b6a36bb94	3	1
\.


--
-- TOC entry 4812 (class 0 OID 16457)
-- Dependencies: 217
-- Data for Name: icons; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.icons (id, image_url) FROM stdin;
6	https://i.pinimg.com/564x/c9/6e/3b/c96e3bf5cde37a002de808e30d3134c0.jpg
5	https://i.pinimg.com/564x/60/d9/a5/60d9a5b6a630fb7833516e3429d62ec4.jpg
4	https://i.pinimg.com/564x/5e/72/a0/5e72a0aaa2dabe6b245d91bfc5ff8f04.jpg
3	https://i.pinimg.com/564x/10/c3/5d/10c35d7573204589ee616855b6670e54.jpg
2	https://i.pinimg.com/564x/1e/48/56/1e4856c8e20fce90ba5e0093895abc04.jpg
1	https://i.pinimg.com/564x/13/13/c5/1313c59a2ad84b0abf6b0a840e418856.jpg
7	https://i.pinimg.com/564x/7d/ff/22/7dff22684d6fc7006d27878118483420.jpg
\.


--
-- TOC entry 4810 (class 0 OID 16397)
-- Dependencies: 215
-- Data for Name: movie; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.movie (id, name, description, image_url) FROM stdin;
9	На линии огня	Бо Гиннер, каждый день рискующий своей жизнью, много лет работает линейным электромонтером – он и его коллеги чинят высоковольтные линии, по которым проходит до 500 тысяч вольт. Одно неверное движение – и конец всему. Когда город оказывается на пути сильнейшего шторма, начинается гонка со временем: у Бо и его команды есть всего несколько часов.	https://cdn-st2.smotrim.ru/vh/pictures/vm/473/330/1.jpg
1	Во власти стихии	Ричард и Тэми познакомились на Таити – это была любовь с первого взгляда. Вместе они отправляются в путешествие по Тихому океану на роскошной яхте. Счастливые и беззаботные, они еще не знают, что у стихии на них свои планы. Неожиданно яхта оказывается в эпицентре мощнейшего урагана. Мачты сломаны, пробоина в корпусе, а до земли сотни миль.	https://cdn-st2.smotrim.ru/vh/pictures/vm/470/787/7.jpg
2	Никита	Никита вместе с друзьями грабит аптеку и убивает полицейского. Суд приговаривает преступницу к пожизненному, но неожиданно кто-то делает ей укол. Когда Никита приходит в себя, ей сообщают, что для всех она умерла и уже похоронена. Теперь у девушки два варианта: или умереть по-настоящему, или пройти обучение и стать тайным агентом.	https://cdn-st1.smotrim.ru/vh/pictures/vm/475/649/2.jpg
3	Разлом	Продолжение фильма "Волна". События разворачиваются спустя 3 года. Геолог Кристиан Айкорд все еще не может оправиться от посттравматического расстройства: его считают героем, а сам он уверен, что мог бы спасти гораздо больше жизней. Затянувшаяся депрессия приводит к тому, что его жена подает на развод.	https://cdn-st1.smotrim.ru/vh/pictures/vm/470/802/0.jpg
4	Идеальная няня	Основано на реальных событиях. Мириам и Поль воспитывают двух маленьких детей. Женщина, устав от декретного отпуска, стремится поскорее выйти на работу, но для этого нужно подыскать хорошую няню. Выбор пары падает на Луизу – миловидную женщину с внушительным педагогическим опытом за плечами.	https://cdn-st1.smotrim.ru/vh/pictures/vm/463/918/8.jpg
5	Эйфель	Париж, конец XIX века. Талантливый инженер Гюстав Эйфель мечтает строить метро, подземную железную дорогу будущего. Однако встреча с таинственной женщиной из его прошлого буквально переворачивает мир Эйфеля. Их головокружительный роман вдохновляет его на создание немыслимого архитектурного шедевра – гигантской ажурной башни, ставшей в итоге символом Парижа, романтики и любви.	https://cdn-st3.smotrim.ru/vh/pictures/vm/468/675/4.jpg
6	Девять жизней	Она в одночасье лишилась всего – мужа, сына, дома, надежды…\n\nЮная Маша Трофимова мечтала о спокойной счастливой жизни. Она хотела поступить в Суриковское училище и выйти замуж за любимого человека Сергея.\n\nНо внезапно пришла беда. Чтобы спасти отца от тюрьмы, Маше приходится связать свою жизнь с чудовищем.\n\n	https://cdn-st4.smotrim.ru/vh/pictures/vm/468/715/9.jpg
7	Чебурашка	Иногда, чтобы вернуть солнце и улыбки в мир взрослых, нужен один маленький ушастый герой! Мохнатого непоседливого зверька из далекой апельсиновой страны ждут удивительные приключения в тихом приморском городке, где ему предстоит найти себе имя, друзей и дом.	https://cdn-st1.smotrim.ru/vh/pictures/vm/471/207/2.jpg
8	Последний богатырь	Иван, обычный парень, по воле случая переносится из современной Москвы в фантастическую страну Белогорье. В этом параллельном мире живут герои русских сказок, волшебство – неотъемлемая часть быта, а спорные вопросы решаются битвой на богатырских мечах.	https://cdn-st1.smotrim.ru/vh/pictures/vm/468/587/2.jpg
10	Я на перемотке	Максим так занят на работе, пытаясь все успеть и не подвести начальство, что не замечает самых важных вещей в своей жизни. В годовщину знакомства с любимой девушкой Сашей, после случайной ссоры с необычной таксисткой Тамарой Петровной у Максима начинают происходить совершенно необъяснимые события. Герою предстоит прожить свою жизнь на перемотке.	https://cdn-st3.smotrim.ru/vh/pictures/vm/468/261/8.jpg
11	Царская прививка	История о том, как впервые в истории России была проведена массовая вакцинация, спасшая десятки тысяч жизней. В 1768 году, в разгар жесточайшей эпидемии оспы, погубившей каждого десятого жителя страны, императрица Екатерина II принимает решение подать личный пример подданным: вместе со своим наследником, цесаревичем Павлом, она первой прививается от страшной болезни и объявляет вакцинацию обязательной для всех.	https://cdnapi.smotrim.ru/api/v1/pictures/4619522/vm/redirect
12	Золото Флинна	История невероятной, полной захватывающих приключений жизни легенды Голливуда – Эррола Флинна. Его скандальная слава распространилась далеко за пределами кинематографа: авантюрист, золотоискатель, сердцеед, звезда. Однако именно эти опасные приключения и выковали героя, которого так полюбил весь мир!	https://cdnapi.smotrim.ru/api/v1/pictures/4687015/vm/redirect
13	Женюсь на первой встречной	Потеряв невесту, Андерсон убежден, что никогда больше не влюбится. Но по настоянию своего лучшего друга, он спонтанно делает предложение вечно недовольной официантке по имени Кэти. Невинный спор перерастает в ту любовь, которую они оба искали всю свою жизнь.	https://cdn-st3.smotrim.ru/vh/pictures/vm/476/708/2.jpg
14	10 дней без мамы в Куршевеле	Потеряв работу, Антуан вынужден взять заботу о детях в свои руки – он готовит, убирает, стирает, делает уроки, да и много чего еще. В то время, как его жена Изабель успешна в бизнесе и зарабатывает деньги. Однако совсем скоро уставший от семейных забот Антуан решает отправиться на альпийский курорт, чтобы провести 10 дней тишины и покоя. Но не тут-то было. Изабель срочно вызывают на работу, а глава семейства летит в Куршевель в сопровождении деток. Что его ждет на месте? Удастся ли ему справиться с непослушными отпрысками и остаться в живых?	https://cdn-st3.smotrim.ru/vh/pictures/vm/482/721/0.jpg
15	Замуж на 2 дня	Чтобы обойти проклятие, разрушившее все первые браки ее семьи, Изабель решает сначала выйти замуж за человека, которого она не любит. Для этого ей нужно найти простачка, влюбить его в себя, расписаться, а потом быстренько развестись. Идеальный план! Если бы не Жан-Ив Бертье, редактор туристического гида, попавшийся на удочку Изабель. Этот импозантный мужчина, вступивший в брачный союз с нашей героиней, наотрез отказывается разводиться. Чтобы добиться своего, Изабель придется даже заглянуть в Москву…	https://cdn-st2.smotrim.ru/vh/pictures/vm/476/572/5.jpg
16	Влюблен без памяти	После исчезновения мужа на полях сражений Первой мировой, Жюли верит, что он не умер. Когда в газете публикуют фотографию выжившего бойца, страдающего от амнезии, она узнает в нем любимого Жюльена. Кажется, что все начинает налаживаться, но в этот момент на пороге дома Жюли появляется незнакомка, утверждающая, что пропавший солдат Жюльен Делоне на самом деле ее муж и что его настоящее имя Виктор Брюне…	https://cdn-st1.smotrim.ru/vh/pictures/vm/476/563/6.jpg
17	Госпожа Бовари	Эмме нет еще и 18 лет, но она уже готовится к свадьбе – мужа, молодого врача, подобрал ей отец-фермер. Юная девушка грезит о садах Парижа и красивых балах... Но замужняя жизнь в маленьком провинциальном городке оказалась иной. Эмма чувствует себя несчастной и вынужденно проводит дни в одиночестве, пока супруг занят с пациентами. Стремясь развлечь себя, она находит утешение в новых модных нарядах и посторонних мужчинах. К чему приведут новые увлечения Эммы и как сложится ее судьба?	https://cdn-st1.smotrim.ru/vh/pictures/vm/476/542/8.jpg
18	Маменькин сынок	Трудоголичке Виолетте из мира моды чуть за сорок и она не может устроить личную жизнь. Неожиданно на курорте она влюбляется в провинциала Жана-Рене. Однако 19-летний сын Виолетты, Лоло, не в восторге от их отношений. Он решает во что бы то ни стало избавиться от возлюбленного своей матери...	https://cdn-st1.smotrim.ru/vh/pictures/vm/483/862/0.jpg
19	О любви	Нина – студентка, жена молодого красавца-профессора, который знает китайский язык и учения Поднебесной. Нина убеждена, что супружеская верность и смирение и есть любовь. Правда, иногда Нине становится скучно и хочется новых романтических приключений. Очень кстати во время одной из встреч, на которую ее отправляет вместо себя Александр, девушка знакомится с Сергеем.	https://cdn-st4.smotrim.ru/vh/pictures/vm/483/096/7.jpg
20	Анжелика, маркиза ангелов	Экранизация одноименного романа Анн и Сержа Голон. О невероятной судьбе красавицы Анжелики, которую выдают замуж за богатого графа де Пейрака. Сначала героиня ненавидит мужа, но вскоре супруги начинают искренне любить друг друга. Однако совместное счастье их длится недолго. Анжелике предстоит пройти на своем пути множество препятствий, предательство и жестокую несправедливость в борьбе не только за любовь, но за свою жизнь...	https://cdn-st3.smotrim.ru/vh/pictures/vm/462/493/4.jpg
\.


--
-- TOC entry 4811 (class 0 OID 16410)
-- Dependencies: 216
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.users (id, logins, passwords, icon) FROM stdin;
0b6f39fb-64ba-4ee6-b0e0-6fcc09fd7d4d	TestUser	102934	1
1	user	123	1
2	pavel	2285qwe	1
3	Pampers	102934qwe	1
b3810e95-0673-479c-9aa6-e70d89489323	TestUserSecond	102934	1
c6057811-2aaa-4cb1-9f74-e16e6bbfc7f8	testUserThird	102934	1
\.


--
-- TOC entry 4814 (class 0 OID 16495)
-- Dependencies: 219
-- Data for Name: watched_movie; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.watched_movie (id, id_movie, id_user) FROM stdin;
28400952-575f-48ab-9f11-3f8802d3bd76	1	2
afa4e446-6cfb-444c-8d50-1aac386199e0	2	1
e018a241-9fd4-4198-8ff2-b8e325c2a9cd	4	1
\.


--
-- TOC entry 4659 (class 2606 OID 16476)
-- Name: favorite_movie favorite_movie_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.favorite_movie
    ADD CONSTRAINT favorite_movie_pkey PRIMARY KEY (id);


--
-- TOC entry 4657 (class 2606 OID 16463)
-- Name: icons icons_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.icons
    ADD CONSTRAINT icons_pkey PRIMARY KEY (id);


--
-- TOC entry 4651 (class 2606 OID 16478)
-- Name: movie movie_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.movie
    ADD CONSTRAINT movie_pkey PRIMARY KEY (id);


--
-- TOC entry 4653 (class 2606 OID 16443)
-- Name: users uniqLogin; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT "uniqLogin" UNIQUE (logins);


--
-- TOC entry 4655 (class 2606 OID 16435)
-- Name: users user_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT user_pkey PRIMARY KEY (id);


--
-- TOC entry 4661 (class 2606 OID 16501)
-- Name: watched_movie watched_movie_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.watched_movie
    ADD CONSTRAINT watched_movie_pkey PRIMARY KEY (id);


--
-- TOC entry 4663 (class 2606 OID 16490)
-- Name: favorite_movie movieConnect; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.favorite_movie
    ADD CONSTRAINT "movieConnect" FOREIGN KEY (id_movie) REFERENCES public.movie(id) NOT VALID;


--
-- TOC entry 4665 (class 2606 OID 16507)
-- Name: watched_movie movieConnectionWatched; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.watched_movie
    ADD CONSTRAINT "movieConnectionWatched" FOREIGN KEY (id_movie) REFERENCES public.movie(id) NOT VALID;


--
-- TOC entry 4664 (class 2606 OID 16485)
-- Name: favorite_movie userConnect; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.favorite_movie
    ADD CONSTRAINT "userConnect" FOREIGN KEY (id_user) REFERENCES public.users(id) NOT VALID;


--
-- TOC entry 4666 (class 2606 OID 16502)
-- Name: watched_movie userConnectionWatched; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.watched_movie
    ADD CONSTRAINT "userConnectionWatched" FOREIGN KEY (id_user) REFERENCES public.users(id) NOT VALID;


--
-- TOC entry 4662 (class 2606 OID 16465)
-- Name: users usersIcons; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT "usersIcons" FOREIGN KEY (icon) REFERENCES public.icons(id) NOT VALID;


-- Completed on 2024-03-11 10:48:14

--
-- PostgreSQL database dump complete
--

