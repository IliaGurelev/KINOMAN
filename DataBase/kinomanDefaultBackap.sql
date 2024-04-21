PGDMP  9                    |            kinoman    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16397    kinoman    DATABASE     {   CREATE DATABASE kinoman WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE kinoman;
                postgres    false            �            1259    16398    favorite_movie    TABLE     �   CREATE TABLE public.favorite_movie (
    id character varying NOT NULL,
    id_movie character varying,
    id_user character varying
);
 "   DROP TABLE public.favorite_movie;
       public         heap    postgres    false            �            1259    16403    icons    TABLE     b   CREATE TABLE public.icons (
    id character varying NOT NULL,
    image_url character varying
);
    DROP TABLE public.icons;
       public         heap    postgres    false            �            1259    16408    movie    TABLE     �   CREATE TABLE public.movie (
    id character varying NOT NULL,
    name character varying,
    description character varying(1200),
    image_url character varying
);
    DROP TABLE public.movie;
       public         heap    postgres    false            �            1259    16413    users    TABLE     �   CREATE TABLE public.users (
    id character varying NOT NULL,
    logins character varying,
    passwords character varying,
    icon character varying DEFAULT 1
);
    DROP TABLE public.users;
       public         heap    postgres    false            �            1259    16419    watched_movie    TABLE     �   CREATE TABLE public.watched_movie (
    id character varying NOT NULL,
    id_movie character varying,
    id_user character varying
);
 !   DROP TABLE public.watched_movie;
       public         heap    postgres    false            �          0    16398    favorite_movie 
   TABLE DATA           ?   COPY public.favorite_movie (id, id_movie, id_user) FROM stdin;
    public          postgres    false    215   g       �          0    16403    icons 
   TABLE DATA           .   COPY public.icons (id, image_url) FROM stdin;
    public          postgres    false    216   �       �          0    16408    movie 
   TABLE DATA           A   COPY public.movie (id, name, description, image_url) FROM stdin;
    public          postgres    false    217   �       �          0    16413    users 
   TABLE DATA           <   COPY public.users (id, logins, passwords, icon) FROM stdin;
    public          postgres    false    218   �0       �          0    16419    watched_movie 
   TABLE DATA           >   COPY public.watched_movie (id, id_movie, id_user) FROM stdin;
    public          postgres    false    219   H1       +           2606    16425 "   favorite_movie favorite_movie_pkey 
   CONSTRAINT     `   ALTER TABLE ONLY public.favorite_movie
    ADD CONSTRAINT favorite_movie_pkey PRIMARY KEY (id);
 L   ALTER TABLE ONLY public.favorite_movie DROP CONSTRAINT favorite_movie_pkey;
       public            postgres    false    215            -           2606    16466    icons icons_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.icons
    ADD CONSTRAINT icons_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.icons DROP CONSTRAINT icons_pkey;
       public            postgres    false    216            /           2606    16429    movie movie_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.movie
    ADD CONSTRAINT movie_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.movie DROP CONSTRAINT movie_pkey;
       public            postgres    false    217            1           2606    16431    users uniqLogin 
   CONSTRAINT     N   ALTER TABLE ONLY public.users
    ADD CONSTRAINT "uniqLogin" UNIQUE (logins);
 ;   ALTER TABLE ONLY public.users DROP CONSTRAINT "uniqLogin";
       public            postgres    false    218            3           2606    16433    users user_pkey 
   CONSTRAINT     M   ALTER TABLE ONLY public.users
    ADD CONSTRAINT user_pkey PRIMARY KEY (id);
 9   ALTER TABLE ONLY public.users DROP CONSTRAINT user_pkey;
       public            postgres    false    218            5           2606    16435     watched_movie watched_movie_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.watched_movie
    ADD CONSTRAINT watched_movie_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.watched_movie DROP CONSTRAINT watched_movie_pkey;
       public            postgres    false    219            6           2606    16436    favorite_movie movieConnect    FK CONSTRAINT     �   ALTER TABLE ONLY public.favorite_movie
    ADD CONSTRAINT "movieConnect" FOREIGN KEY (id_movie) REFERENCES public.movie(id) NOT VALID;
 G   ALTER TABLE ONLY public.favorite_movie DROP CONSTRAINT "movieConnect";
       public          postgres    false    215    4655    217            8           2606    16441 $   watched_movie movieConnectionWatched    FK CONSTRAINT     �   ALTER TABLE ONLY public.watched_movie
    ADD CONSTRAINT "movieConnectionWatched" FOREIGN KEY (id_movie) REFERENCES public.movie(id) NOT VALID;
 P   ALTER TABLE ONLY public.watched_movie DROP CONSTRAINT "movieConnectionWatched";
       public          postgres    false    219    217    4655            7           2606    16446    favorite_movie userConnect    FK CONSTRAINT     �   ALTER TABLE ONLY public.favorite_movie
    ADD CONSTRAINT "userConnect" FOREIGN KEY (id_user) REFERENCES public.users(id) NOT VALID;
 F   ALTER TABLE ONLY public.favorite_movie DROP CONSTRAINT "userConnect";
       public          postgres    false    4659    215    218            9           2606    16451 #   watched_movie userConnectionWatched    FK CONSTRAINT     �   ALTER TABLE ONLY public.watched_movie
    ADD CONSTRAINT "userConnectionWatched" FOREIGN KEY (id_user) REFERENCES public.users(id) NOT VALID;
 O   ALTER TABLE ONLY public.watched_movie DROP CONSTRAINT "userConnectionWatched";
       public          postgres    false    219    218    4659            �   N   x����  �7�BF�4������;����K��E�֡���*�����\G��|9��C�N��߃�?�xF      �   �   x�}��N!���0���R|/ʺ&���_��<	i��G���xܿ_����y�]��u����p[��mJ��i����Ĺ��q�lr")¨�bT�����c���Lu(E�O)�HPWrtw�Be5��eN�xH|"%�� cEgE
f��IM֖Z0��L
ȶrE6�nA8{Tl.�X٪x��;�3��N�5w�N>,7�6uM�9ٺ�)����V�I����^uP�b)Y����߽�۶�R"��      �      x��[�r�]C_1�"��M���,�I9�ة��d��%*�	[r�b[��rVI�9x~a���t��}�H��r�D ���������4��UQ-��"��j\-ףV�uU&�|���u��T�*�.�����&դ���gɺW�~5[�����4���,��c��Ε>�>����P��z��N���\�_}��"ߕ/�U�d��>*���RV(僁�H_%��^街�>��3yc�o����]q=�ų����zĹ�k���H
rЕ�#���R�t���|m"W��d{;��ɲ�Ó�^u+�~�'����'Ñ���~3��.U��o�[<�J���//�CY�%�6QU��<z��H�+9\F��t�T�:����B�C��OMD�S^Lę��J)^g����H���pf��^�&����eIyB�Dޕ�b#v���Bͅb�UA)��m�>z���:�����w�|��?�d���/>�|��?�����t�w;��۝�֟?�ӝn�z�C�S�w�Da��V�����Ttr��bX�CT�*���5��3�k��������*������;�s5`���B_�S=gn晬=��F�>Q�s� N��n�s�jO��I�#SA��Us�V{�}���J5ZC���zpX+$-_V���Ot59�ϔ��R���r�Y�J�s��o��Qsq�JL(4=l[T��ֱ�M�K}�� ��q�39��]	���l�]��-<SPXɪ��A
�bK)�۰�!�:��*�����_�<s���Y���,x�Ѓ��BJ����'��`�^lA_��ow�;�����BvU{K/Ԓj�QC�.E8�Ķ`�cS`S*� 7��Wy�B��(�DR�S�Gc���(��&����=�uT��u�W5�L,i�@��Me+�W�]:�Ɣ�o��Cv R41�!4F�,�\�Gm[D�E4+��4W����_�����N���.��t�	��Z��ϫ�y�L�T�H���(��+��f�r��qn�@���L�������[œ=�8�XA��(� �Jٴ��[mt�s�w�ف��*��S�{Z�+�#�S�֏,�%�*6��r�w��p�3�Ĉ�J�A�Bʨ'8���'/G�.����IO1� �5U�I��\��;17�kK���|1�4/���|��E�k��䱾1���*�P��ׂZ�uٱ��,0E�JUCJc� �D���.x���*�8�*@�҅��S�b�S��a#�"�Sy5�M�`ݥ�P�9V��,�٨!��,�S�)���k�4[Mngo۝���6�m�U}�3��cR��Dh�r�%Q�A;����N���'��y���E�1��-�OD�9�/P�"ت���GOD�	mW��ljP���d�`��/і4��V!��9���@�6bv��7Rc_ 3|}��/݄
�w!�+k��t�^��)��?����!���	
�ϒJ��,�Y׼�����^.��t�-/'�-=|�u}euj�t��"WV����v;�ݣ��m�U�G���g|3�l������^O������Χ�	l�����^�%c�6I��(@I���@t�7��e��H�m��Ă�X�х�sy�)6�%���FښJN��S�v�bƧ���u�&G��cd��Yp�ҩq���� 5�^,���;��������r�X��冀�81XP�m|b��ORXLt;),������m���R8�P���QJ��3�,@L5�^�/N�S򢝸5`�)ga��3u[0���SF�#�l��d�=`��p�9�(�8hU��Z#�_Go7.��Z��2hud��y�#���B
y���k��?}��꿎��Cl��������j�e+$��O=��73�iޭ�_�6N��9�r0���W��,XF0E�	��ǧ�ME�)�opEEնG3�(ORwQ�0ڂ,~`B�����ޥ�S����)��7�:c� �RR�$���!���k�ڙ�����`�|��c%����>�+ξa�{�a�����1��U�l�Xu��`��\ի,�4�������#��[� :��[�<W���8�+�@��F�Gz"�S���n��ʒ�F��B	��+3�̘CP�@։�`dE�0,�-��&p��jv�cgH麕E� =s��z��h���{՞���N ��,@�C���\Hգ�^���8�jdf���
Á���ngg��Ғ#��� ���~���0�3��b;1>���i���?"/�x�N�Ì�c�@�Tc,bEe2C�e�P͍,�b��H�(��QaZ�y�n�N��i�V?�a{��"�u�6z��}㯤��A̶�0O�u$����x��G��h�8�*:�d��׬`2fy��Z
�g �p�P�B�yI8����%���'��yG��#���v���KM� ��vK�P�LF4#�[�I����̪<��cyȦ�ܓ.�jN��ה�M�y���R��QD��m`ї��`է�&n(�#�=�<Z�չx\�=�T�f�o�̨QM۞�4�&�}�ӱ.�A�|`�b�l�׸{JdUdl�_&��Xsm�o+#��(�Y� �����*P��7�H� `��7������/�`~��n;]K^��V�X+��(���;���#�[g�&d5l���ԁ������E(��L'$�K�:G=���$S1��횟��	cY��J���<��)#�ͼ栘�C�b'��f��\X�U�3K��^,uZn}/����J/�x�5�1�v�f��r��1���6����jI��Xn�Y��A�Y�/�9st}̊��L��,�#� ���(t�hʛi,kC��D��M���wluQ徬��4t%X�bkY�y_��]7�s>g�4����ná���Ǳ?����ڧ����;;�[�?����?����N��;�0b�Y�����f_	#���^r���O�u��)�����߉u6sﲽ���D�G���?�=|�6���ǲ$,{I�jk0����f��f�q�qT/����`W�-݅�a��Ҕ�����������]�5�P�Nм���F���o8����8�� 8���-�Yuq�z�)���=�3� E[̜'�'{�V�xt�-�P�w[Vb<�z�ߋK:07Rc���Tm�}+~#�6�}�D�Y�vh�>L�ڼ$ó�����+�NG]H���'P�:w��A%q&������"7�9�n�����kO���w_D1�BZ>V��B�kYft&����@n��0Ѡ��R��S[kv�
��P�6O�S}���n�:��G�~�Z��n��s�8$���/5�:2�7�h����xh%8-� ��0����IW���-�G��)
�=�16@@N۶�&N��5���a(hA����E�(p{��3��A4�`��l||gWb-7P��P)�p��6�A&� h+6U��� ��C!I��Q����YKB���7U�Y��¢I����0F(s�Z^�+�41�Z���t���,��O �[w�q�^oH�����������Є �2&y+y�X �.���[9�${Ar��E3��%���.��	R�w�4�D����ɓ%[��@�ao��Mr\o���<~w$9���t�=��WjJ�z�hZ�su��d��BW�s�B�gw��i��yh�62�<<��rS�ئ���y�֍\�mx���������^���D��\�a��[]���ŝ��,O<��a"h���2�\��ĥ�ZyO��R9�*�zA�w�-�+��3/��~tW�i�Q��ku��XN9�!Aњ&E���s���F�wXNV�h�h�wKI�D��"��o�z%�����033��M�Lq��y�%���F ��Ei2�J,��>���kGnT��L.^^��k�m�uR�V$�V*�ę����ur�k�[M(t�w:�t�����ڍ;��B�����K�Jk(�^[3(0�ppBHO���O`��lZ�[�򭜅4��t<�ڀXbc6�9�,A���{ �  ���Z�M��T[6Rd�
���>x1�ܾ]W &���ǟ �ٿ�i�8b���"���="^V=���m������X'�u���{:r,c�t�-A~C�Z��C�.�
�>$���yc�rf#��eR���!�����C�^���Cw7������������)t\�PV}-8w��\���7*ăv;��Öf������,T����%aPG�M\]�v��vL�ψ!b�"�3MX�hnu౓]�0hPZ��[c�����׽�T�K�S�$��A.���I����g�j�H�'G��dk�iaӨÏ��l�A�X�@YZ�5I��0mj�"��Q4PK��fF�(�ε/�ܣ6�OI\K��em�ѐՄ)`Z�{>����'��kc��%8��]��S�Odp��03���Lf�Fc��rH�":�����k,Q�����GӓKk���cY/I�BG�`E�,ۏ�ng�
TdS5��]�|#1��&��M?���R��D���/}�A���A�s�� ��	*%}���`���D�=�'��lf���*�5��gmR2��"�Y9�y�kF9���5-m�{v��!.`��n��od��㻖h-�Un�A���W�l@�l	���t�`�S�uld�2��X&���9s��A��B3�̈�u��ᶨ+��`������с�?v�[Տ�\�V�5:;1wg*� �AV�c��G6����v�/�$�&6v� ���UR�W�����P��oc�ӭ$��Ye�'9bx��|��G�o6c��Z�KE�����&���D�	GQ�?R��_6����PpB�ILr׍��z`�e}5O����<E'���Oa�*��EU޶;n����oĿ-q��CE���V}6𓯍x���LO4���ݴ�����o���[�Es��0sf�w�Dj����+_���ĕ7kqE����(�,|�c?M��"���yC?'"yï�s��d��������6����CȔ�g�p���V����o�6�L�y���s�Q����6\ܠ�xB�L��z&ظ ����P¿��l�����g	m�z^�n/��m��)��-=�xL�zQ�H�
���k���
Ek��մ]wB?��J5�m�Ǌ���ؗC����6
�_��ӂ�;X��75�Ś���t��wm����;w����T      �   �   x�M�I�0��_���=�@"ܸx$���> �Z��n����s/B�Q����j���^�y;ɨZv^mՐ�rT������8�N�A��z��A���� �D kd�Y���H���o�v!6��[��bH(�VB�j����0��F�^���N�VZ�'�u=�      �   e   x���!������B.�A��C��w��}*�w�b���2c=c�w5iڣX��6H�3�$"�-q�ܴI�,
�����U)m�Cgjx�������X     