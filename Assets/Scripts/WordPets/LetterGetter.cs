using UnityEngine;

namespace WordPets
{
    internal static class LetterGetter
    {
        // Fields
        private static WordPets.Letter[] vowels;
        private static int vowelTopNum;
        private static WordPets.Letter[] easyVowels;
        private static int easyVowelsTopNumber;
        private static WordPets.Letter[] consonant;
        private static int consonantTopNum;
        private static WordPets.Letter[] easyConsonants;
        private static int easyConsonantsTopNumber;
        public static int vowelsGeneratedRandomly;
        public static int lettersGeneratedSoFar;
        private static bool init;
        
        // Methods
        public static void Init()
        {
            var val_4;
            var val_5;
            WordPets.Letter[] val_8;
            var val_11;
            var val_12;
            var val_14;
            var val_16;
            var val_18;
            val_4 = null;
            val_4 = null;
            if(WordPets.LetterGetter.init == true)
            {
                    return;
            }
            
            val_5 = 1152921505004933160;
            WordPets.LetterGetter.init = true;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_10 = 101;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_14 = 3333;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_18 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_1C = 97;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_20 = 2143;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_24 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_28 = 111;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_2C = 1970;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_30 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_34 = 105;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_38 = 1828;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_3C = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_40 = 117;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_44 = 723;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_48 = 0;
            WordPets.LetterGetter.vowels = null;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_10 = 101;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_14 = 3333;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_18 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_1C = 97;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_20 = 2143;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_24 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_28 = 111;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_2C = 1970;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_30 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_34 = 105;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_38 = 1828;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_3C = 0;
            WordPets.LetterGetter.easyVowels = null;
            val_8 = null;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_10 = 116;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_14 = 1463;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_18 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_1C = 110;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_20 = 1090;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_24 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_28 = 115;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_2C = 1022;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_30 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_34 = 104;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_38 = 984;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_3C = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_40 = 114;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_44 = 967;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_48 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_4C = 100;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_50 = 687;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_54 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_58 = 108;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_5C = 650;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_60 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_64 = 99;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_68 = 449;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_6C = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_70 = 109;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_74 = 388;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_78 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_7C = 119;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_80 = 381;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_84 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_88 = 102;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_8C = 359;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_90 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_94 = 103;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_98 = 325;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_9C = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_A0 = 121;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_A4 = 318;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_A8 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_AC = 112;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_B0 = 311;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_B4 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_B8 = 98;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_BC = 241;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_C0 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_C4 = 118;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_C8 = 157;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_CC = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_D0 = 107;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_D4 = 124;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_D8 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_DC = 106;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_E0 = 25;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_E4 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_E8 = 120;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_EC = 24;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_F0 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_F4 = 113;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_F8 = 15;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_FC = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_100 = 122;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_104 = 11;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_108 = 0;
            WordPets.LetterGetter.consonant = null;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_10 = 116;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_14 = 1463;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_18 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_1C = 110;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_20 = 1090;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_24 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_28 = 115;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_2C = 1022;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_30 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_34 = 104;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_38 = 984;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_3C = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_40 = 114;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_44 = 967;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_48 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_4C = 100;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_50 = 687;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_54 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_58 = 108;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_5C = 650;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_60 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_64 = 99;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_68 = 449;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_6C = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_70 = 109;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_74 = 388;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_78 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_7C = 119;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_80 = 381;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_84 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_88 = 102;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_8C = 359;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_90 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_94 = 103;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_98 = 325;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_9C = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_A0 = 112;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_A4 = 311;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_A8 = 0;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_AC = 98;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_B0 = 241;
            typeof(WordPets.Letter[]).__il2cppRuntimeField_B4 = 0;
            val_11 = null;
            WordPets.LetterGetter.easyConsonants = null;
            val_12 = 0;
            WordPets.LetterGetter.consonantTopNum = 0;
            val_11 = null;
            if(WordPets.LetterGetter.consonant == null)
            {
                    val_11 = null;
            }
            
            val_11 = null;
            val_14 = 0;
            WordPets.LetterGetter.easyConsonantsTopNumber = 0;
            val_11 = null;
            if(WordPets.LetterGetter.easyConsonants == null)
            {
                    val_11 = null;
            }
            
            val_11 = null;
            val_16 = 0;
            WordPets.LetterGetter.vowelTopNum = 0;
            val_11 = null;
            if(WordPets.LetterGetter.vowels == null)
            {
                    val_11 = null;
            }
            
            val_11 = null;
            val_18 = 0;
            WordPets.LetterGetter.easyVowelsTopNumber = 0;
            val_11 = null;
        }
        public static void Reset()
        {
            null = null;
            WordPets.LetterGetter.lettersGeneratedSoFar = 0;
            WordPets.LetterGetter.vowelsGeneratedRandomly = 0;
        }
        public static char getRandomLetter(int[] letterOccuranceCounter)
        {
            var val_7;
            var val_8;
            int val_10;
            int val_11;
            val_7 = null;
            val_7 = null;
            if(WordPets.LetterGetter.init != true)
            {
                    WordPets.LetterGetter.Init();
                val_7 = null;
            }
            
            val_7 = null;
            int val_7 = WordPets.LetterGetter.lettersGeneratedSoFar;
            val_7 = val_7 + 1;
            WordPets.LetterGetter.lettersGeneratedSoFar = val_7;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  100);
            val_8 = null;
            val_10 = WordPets.LetterGetter.lettersGeneratedSoFar;
            if(val_10 != 0)
            {
                    val_8 = null;
                val_10 = WordPets.LetterGetter.lettersGeneratedSoFar;
                val_11 = WordPets.LetterGetter.vowelsGeneratedRandomly;
                float val_8 = (float)val_10;
                val_8 = (float)val_11 / val_8;
            }
            
            val_8 = null;
            int val_9 = WordPets.LetterGetter.vowelsGeneratedRandomly;
            val_9 = val_9 + 1;
            WordPets.LetterGetter.vowelsGeneratedRandomly = val_9;
            return WordPets.LetterGetter.getVowel();
        }
        public static char getVowel()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_2 = null;
            val_2 = null;
            if(WordPets.LetterGetter.init != true)
            {
                    WordPets.LetterGetter.Init();
                val_2 = null;
            }
            
            val_2 = null;
            val_3 = 0;
            val_4 = 0;
            goto label_8;
            label_17:
            val_5 = null;
            val_5 = null;
            if((UnityEngine.Random.Range(min:  0, max:  WordPets.LetterGetter.vowelTopNum)) < (WordPets.LetterGetter.vowels + 12 + 24))
            {
                goto label_13;
            }
            
            val_3 = 12;
            val_4 = 1;
            label_8:
            val_6 = null;
            val_6 = null;
            if(val_4 < (WordPets.LetterGetter.vowels + 12))
            {
                goto label_17;
            }
            
            return 33;
            label_13:
            val_7 = null;
            val_7 = null;
            if((WordPets.LetterGetter.vowels + 12) > val_4)
            {
                    return (char)WordPets.LetterGetter.vowels + 12 + 16;
            }
            
            return (char)WordPets.LetterGetter.vowels + 12 + 16;
        }
        public static char getConsonant()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_2 = null;
            val_2 = null;
            if(WordPets.LetterGetter.init != true)
            {
                    WordPets.LetterGetter.Init();
                val_2 = null;
            }
            
            val_2 = null;
            val_3 = 0;
            val_4 = 0;
            goto label_8;
            label_17:
            val_5 = null;
            val_5 = null;
            if((UnityEngine.Random.Range(min:  0, max:  WordPets.LetterGetter.consonantTopNum)) < (WordPets.LetterGetter.consonant + 12 + 24))
            {
                goto label_13;
            }
            
            val_3 = 12;
            val_4 = 1;
            label_8:
            val_6 = null;
            val_6 = null;
            if(val_4 < (WordPets.LetterGetter.consonant + 12))
            {
                goto label_17;
            }
            
            return 33;
            label_13:
            val_7 = null;
            val_7 = null;
            if((WordPets.LetterGetter.consonant + 12) > val_4)
            {
                    return (char)WordPets.LetterGetter.consonant + 12 + 16;
            }
            
            return (char)WordPets.LetterGetter.consonant + 12 + 16;
        }
        public static char getRandomEasyLetter(int[] letterOccuranceCounter)
        {
            var val_7;
            var val_8;
            int val_10;
            int val_11;
            val_7 = null;
            val_7 = null;
            if(WordPets.LetterGetter.init != true)
            {
                    WordPets.LetterGetter.Init();
                val_7 = null;
            }
            
            val_7 = null;
            int val_7 = WordPets.LetterGetter.lettersGeneratedSoFar;
            val_7 = val_7 + 1;
            WordPets.LetterGetter.lettersGeneratedSoFar = val_7;
            int val_1 = UnityEngine.Random.Range(min:  0, max:  100);
            val_8 = null;
            val_10 = WordPets.LetterGetter.lettersGeneratedSoFar;
            if(val_10 != 0)
            {
                    val_8 = null;
                val_10 = WordPets.LetterGetter.lettersGeneratedSoFar;
                val_11 = WordPets.LetterGetter.vowelsGeneratedRandomly;
                float val_8 = (float)val_10;
                val_8 = (float)val_11 / val_8;
            }
            
            val_8 = null;
            int val_9 = WordPets.LetterGetter.vowelsGeneratedRandomly;
            val_9 = val_9 + 1;
            WordPets.LetterGetter.vowelsGeneratedRandomly = val_9;
            return WordPets.LetterGetter.getEasyVowel();
        }
        public static char getEasyVowel()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_2 = null;
            val_2 = null;
            if(WordPets.LetterGetter.init != true)
            {
                    WordPets.LetterGetter.Init();
                val_2 = null;
            }
            
            val_2 = null;
            val_3 = 0;
            val_4 = 0;
            goto label_8;
            label_17:
            val_5 = null;
            val_5 = null;
            if((UnityEngine.Random.Range(min:  0, max:  WordPets.LetterGetter.easyVowelsTopNumber)) < (WordPets.LetterGetter.easyVowels + 12 + 24))
            {
                goto label_13;
            }
            
            val_3 = 12;
            val_4 = 1;
            label_8:
            val_6 = null;
            val_6 = null;
            if(val_4 < (WordPets.LetterGetter.easyVowels + 12))
            {
                goto label_17;
            }
            
            return 33;
            label_13:
            val_7 = null;
            val_7 = null;
            if((WordPets.LetterGetter.easyVowels + 12) > val_4)
            {
                    return (char)WordPets.LetterGetter.easyVowels + 12 + 16;
            }
            
            return (char)WordPets.LetterGetter.easyVowels + 12 + 16;
        }
        public static char getEasyConsonant()
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_2 = null;
            val_2 = null;
            if(WordPets.LetterGetter.init != true)
            {
                    WordPets.LetterGetter.Init();
                val_2 = null;
            }
            
            val_2 = null;
            val_3 = 0;
            val_4 = 0;
            goto label_8;
            label_17:
            val_5 = null;
            val_5 = null;
            if((UnityEngine.Random.Range(min:  0, max:  WordPets.LetterGetter.easyConsonantsTopNumber)) < (WordPets.LetterGetter.easyConsonants + 12 + 24))
            {
                goto label_13;
            }
            
            val_3 = 12;
            val_4 = 1;
            label_8:
            val_6 = null;
            val_6 = null;
            if(val_4 < (WordPets.LetterGetter.easyConsonants + 12))
            {
                goto label_17;
            }
            
            return 33;
            label_13:
            val_7 = null;
            val_7 = null;
            if((WordPets.LetterGetter.easyConsonants + 12) > val_4)
            {
                    return (char)WordPets.LetterGetter.easyConsonants + 12 + 16;
            }
            
            return (char)WordPets.LetterGetter.easyConsonants + 12 + 16;
        }
        private static LetterGetter()
        {
        
        }
    
    }

}
