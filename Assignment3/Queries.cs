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

        public static IEnumerable<string> FindWizardsByAuthor(string author, IEnumerable<Wizard> wizards)
        {
            return wizards.Where(wizard => wizard.Creator.Equals(author)).Select(wizard => wizard.Name);
        }

        public static int? FindYearOfFirstSith()
        {
            var wizards = Wizard.Wizards.Value;
            
            var sorted = from w in wizards
            where w.Name.StartsWith("Darth ")
            orderby w.Year descending
            select w.Year;

            return sorted.FirstOrDefault();
        }

        public static int? FindYearOfFirstSith(IEnumerable<Wizard> wizards)
        {
            return wizards.Where(wizard => wizard.Name.StartsWith("Darth "))
                          .OrderByDescending(wizard => wizard.Year)
                          .Select(wizard => wizard.Year).FirstOrDefault();
        }

        public static IEnumerable<(string,int?)> FindUniqueWizardsFromHarryPotter() 
        {
            var wizards = Wizard.Wizards.Value;
            var sorted = from w in wizards
            where w.Medium.Contains("Harry Potter")
            orderby w.Year
            select (w.Name, w.Year);

            return sorted.Distinct();
        }

        public static IEnumerable<(string,int?)> FindUniqueWizardsFromHarryPotter(IEnumerable<Wizard> wizards)
        {
            return wizards.Where(wizard => wizard.Medium.Contains("Harry Potter"))
                          .OrderBy(wizard => wizard.Year)
                          .Select(wizard => (wizard.Name, wizard.Year)).Distinct();
        }

        public static IEnumerable<string> FindWizardNamesInReverseOrderGroupedByCreator() 
        {
            var wizards = Wizard.Wizards.Value;
            
            var sorted = from w in wizards
            group w by (w.Creator, w.Name) into g
            orderby g.Key.Creator descending, g.Key.Name ascending
            select g.Key.Name;

            return sorted;
        }

        //Extension methods
         
        public static IEnumerable<string> FindWizardNamesInReverseOrderGroupedByCreator(IEnumerable<Wizard> wizards)
        {
            return wizards.GroupBy(wizard => (wizard.Creator, wizard.Name))
                                 .OrderByDescending(g => g.Key.Creator).ThenBy(g => g.Key.Name)
                                 .Select(g => g.Key.Name);
        }
    }
}
