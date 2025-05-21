using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDFOperation.IDF
{
    internal class Idf
    {
        private DateTime dateOfEstablishment;
        private Commander currentCommnader;
        private List<StrikeOption> strikeOptions;

        public Idf(DateTime dateOfEstablishment, Commander currentCommnader, List<StrikeOption> strikeOptions)
        {
            this.dateOfEstablishment = dateOfEstablishment;
            this.currentCommnader = currentCommnader;
            this.strikeOptions = strikeOptions;
        }
        public DateTime GetDateOfEstablishment()
        {
            return this.dateOfEstablishment;
        }

        public void SetDateOfEstablishment(DateTime dateOfEstablishment)
        {
            this.dateOfEstablishment = dateOfEstablishment;
        }
        public Commander GetCurrentCommnader()
        {
            return this.currentCommnader;
        }
        public void SetCurrentCommnader(Commander currentCommnader)
        {
            this.currentCommnader = currentCommnader;
        }
        public List<StrikeOption> GetStrikeOptions()
        {
            return this.strikeOptions;
        }
        public void AddStrikeOption(StrikeOption strikeOption)
        {
            this.strikeOptions.Add(strikeOption);
        }
        public void RemoveStrikeOption(StrikeOption strikeOption)
        {
            this.strikeOptions.Remove(strikeOption);
        }
    }
}
