PGDMP  *                    |            kinoman    16.2    16.0     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    16396    kinoman    DATABASE     {   CREATE DATABASE kinoman WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE kinoman;
                postgres    false            �            1259    16397    movie    TABLE     �   CREATE TABLE public.movie (
    id integer NOT NULL,
    name character varying,
    description character varying(381),
    image_url character varying
);
    DROP TABLE public.movie;
       public         heap    postgres    false            �          0    16397    movie 
   TABLE DATA           A   COPY public.movie (id, name, description, image_url) FROM stdin;
    public          postgres    false    215   Y                  2606    16403    movie movie_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.movie
    ADD CONSTRAINT movie_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.movie DROP CONSTRAINT movie_pkey;
       public            postgres    false    215            �   G
  x��X�r�]C_q�5�ߔ� ��vN�v�$�$�k<�4h"�R�˖숋x�d0�@3�`�w~�_�>���(?��R��۷�����Aǿ���+����Ϝ/�ܯ�i��͗ο惵O�~����_T�;��x骾Ϫ���F�Uu!��N.1�ⵥ�y��+�P�-�Pbʹ����|Y�/n�/�|4񅫾��b(�b��Cx�+�s�5�^;8������Ws�[��b5�񤚈s%߀�+�kȅ�V�эّ�eէ#~�%��|��-���zN\��k��8�����!�'���~�/Yh���Tw����K�:��E5C�1h�j���6b�^�K4x����u$�gHE4�չ��:׍I8�.?�(����,#%��!�,�j�%ۑ��D�`�63�X .&�E�bf%��|vz����(��OO�??��y����g�?�y�e��g���?9��ٟ�G_=������^��󗧟����WtR�cU�$a�Ҏ����B}�N<�`�!�B�k�>��K�<�hY��A䜟I�W���
 �-J-`yN��=���H���"H�R�5'WVB�7��,IHd���xQ|^sw%@�hHz\�q������;)�i5�5��F]� �D+@|�����/T%k�[��J��L�Ӡ�ٮ��Q���A� �qH�_�ω��V�+I��b^ƿ�����/�A ��R�s�p>bX納��Q��g�ZM�V�Le�~'� }�`�(�Z��uT�J�a��
������G�D��8�U��x�Hj��-��F�K��<72%7�����9B^���XvC���V�0c�
A42r@¢i�x��Gb�}�EnԪ>ib��$��N6�ݗ����SVa�Y�L�́[a��mVN�fVM�f�"�tl�U�XO�@ J��X�`������!Lt@Ե�bͣ�G��D s��<b��?tJ3�Z���q�e5 AOQnB��`������Tr�#��bZcS}�e�rARnct�71z<����}P��VO����xjZ����ԗ��,�e_at{B���xn�/��D��b�԰��r���+)��&���\С26c��*��]X��ɫ 	��&�aS�)�J��О,�H��w �L����H��� �bZ�`vn�E2KN[12#�P� �l�Z�.g�[��ř@ �K3S��bS������A�q.WS�) Jz��X�'MM�8��|�~�9����x�Yf��nx�E'���G�t���16S�p'"S���R�d�r�� m�Pc��dV�ߏ:*8�`�,���cǎ�R�K3�$[��|t�M���@�ajARf�7bX����G�%��,4�M��� ��4PG�=�!\�7�,��Hf|�|Q��0vu(b>�
�Eւ��#��w�c;��{1.���U)UR�,�2l.��P- �k�e�ZΨ��rAڂ�M�eZ+�3 �ʊ��	oG�уݓ�x;���H\_�/�o���n[��Ǐ�y����F\�=�;b@�#E�^�j0�q�g�TSI�M�`w��Pe�?Z!]Q�ٍ�5�9���\�_h��c	�.�Q���!��Qm<�J�ސ\�4��ѹ�
d��.�2H��6�+� �~;,Sq�[T��hDrCѳ����lH�O������y�j~U!��a�	Ea�t����-�	td#��P�g��(V�ϩ��k9��0G��Y�4�TNřY��:�:P*�k(�#���QldaI>���߬���H��+����mM~�>"|[k�R�[�#.m�F!��5�)#0wJp�G*�z
e<y��s�ߏ�<z���Æy�H{ai��jʇ���&�c~f����0�{�X�Ƙl���� F�.��w�g�����Q���xa�T��1Rq�FW��kTq
s�
t�ba��X�Ձr�Z���� ���ߙr���'�Cŀ�Q�����i�4���:(1�V�f�yN�ǎxHg�e}���~�ǻ��������$GUC��8	�NY04��ԝsLɯ��X-IM:2�۴��\�>��N����9�PH��F��@,���V��P�&5
�:P&:Ch�ɬ[����R�am���n�1ֱxF��n'��2�V�
 ��`C�0�'��
~)���������jHY����FTtΡR�[+8����ė�M&�F{�cKNЩ�Aw��P�	�	��P(v���3�*k4���O��D�bmǪ�L�s�Z�!cz��:&3�c�-!B1�h�%&lؼ[���Z:*����WA����N;����������)��S�L���\cv��9�NE��7�wq�k;�H9M] V����8�5BƐ�بJ�P��|��.]f^+����U����ɼ���$�e�������҂�/��	%!����n���y[p�T��T:�?�36�͞��;����k�ŭ!h�,;k�îM"��`�!��6���EP�p�N�*�рk���C�0�R��;U�}���k������i����ӮY��v:`����X�*��0[!?�v��̱>���mc�z��j� �y�C�6�}�d�J
x{��#����O�\6K}�/~w�n{G�6�<ڹw����|�a     