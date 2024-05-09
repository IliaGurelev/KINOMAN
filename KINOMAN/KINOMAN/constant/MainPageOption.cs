using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KINOMAN.constant
{
    internal class MainPageOption
    {
        public static readonly int MOVIE_SHOW_FILM = 5;

        static public Dictionary<int, int[]> INDEX_IMAGE_TABLE_LAYOUT()
        {
            return new Dictionary<int, int[]>()
            {
                {1, new int[] {0, 0}},
                {2, new int[] {1, 0}},
                {3, new int[] {2, 0}},
                {4, new int[] {3, 0}},
                {5, new int[] {4, 0}},
                {6, new int[] {5, 0}},
                {7, new int[] {0, 2}},
                {8, new int[] {1, 2}},
                {9, new int[] {2, 2}},
                {10, new int[]{3, 2}},
                {11, new int[]{4, 2}},
                {12, new int[]{5, 2}},
            };
        }

        static public Dictionary<int, int[]> INDEX_TEXT_TABLE_LAYOUT()
        {
            return new Dictionary<int, int[]>()
            {
                {1, new int[] {0, 1}},
                {2, new int[] {1, 1}},
                {3, new int[] {2, 1}},
                {4, new int[] {3, 1}},
                {5, new int[] {4, 1}},
                {6, new int[] {5, 1}},
                {7, new int[] {0, 3}},
                {8, new int[] {1, 3}},
                {9, new int[] {2, 3}},
                {10, new int[]{3, 3}},
                {11, new int[]{4, 3}},
                {12, new int[]{5, 3}},
            };
        }
    }
}
