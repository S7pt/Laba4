using System;
using System.Collections;

namespace Laba4Task3.models
{
    public class Performance
    {
        private string surname;
        private string group;
        private int ukrainianLanguageMark;
        private int mathematicsMark;
        private int englishLanguageMark;

        public override string ToString()
        {
            return surname + " " + group + " " + ukrainianLanguageMark + " " + mathematicsMark + " " +
                   englishLanguageMark+" ";
        }

        public Performance(string surname, string group, int firstMark, int secondMark, int thirdMark)
        {
            this.group = group;
            this.surname = surname;
            ukrainianLanguageMark = firstMark;
            mathematicsMark = secondMark;
            englishLanguageMark = thirdMark;
        }
        public Performance(){}

        public string GetSurname()
        {
            return surname;
        }
        public string GetGroup()
        {
            return group;
        }

        public int GetUkrainianLanguageMark()
        {
            return ukrainianLanguageMark;
        }

        public int GetMathematicsMark()
        {
            return mathematicsMark;
        }

        public int GetEnglishMark()
        {
            return englishLanguageMark;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetGroup(string group)
        {
            this.group = group;
        }

        public void SetUkrainianMark(int ukrainianLanguageMark)
        {
            this.ukrainianLanguageMark = ukrainianLanguageMark;
        }

        public void SetMathematicsMark(int mathematicsMark)
        {
            this.mathematicsMark = mathematicsMark;
        }

        public void SetEnglishLanguageMark(int englishLanguageMark)
        {
            this.englishLanguageMark = englishLanguageMark;
        }

    }
}