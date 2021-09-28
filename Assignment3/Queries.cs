using System;
using System.Linq;
using System.Collections.Generic;


namespace BDSA2021.Assignments03
{
    public class Queries
    {
        public static IEnumerable<string> FindWizardsByAuthor(string author)
        {
            var wizards = Wizard.Wizards.Value;
            return from w in wizards
            where w.Creator.Equals(author)
            select w.Name;
        }

        public static int? FindYearOfFirstSith()
        {
            var wizards = Wizard.Wizards.Value;
            
            var sorted = from w in wizards
            where w.Name.Contains("Darth")
            orderby w.Year descending
            select w.Year;

            return sorted.FirstOrDefault();
        }

        public static IEnumerable<(string,int?)> FindUniqueWizardsFromHarryPotter() 
        {
            var wizards = Wizard.Wizards.Value;
            var sorted = from w in wizards
            where w.Medium.Contains("Harry Potter")
            orderby w.Year descending
            select (w.Name, w.Year);
            return sorted.Distinct();
        }

/* 
        public static IEnumerable<string> FindWizardNamesInReverseOrderGroupedByCreator() 
        {
            var wizards = Wizard.Wizards.Value;
            var sorted = from w in wizards
            group (w.Creator, w.Name) by w.Creator into g
            orderby g.Creator ascending, g.name descending
            select g.Key;
            return sorted;
        } */
    }
}
