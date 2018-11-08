using System.Collections.Generic;
using fprs.Core.Entity;

namespace fprs.Core.DomainService
{
    public interface ICompanyService
    {
        //Create
        Company createCompany(Company company);

        //Read
        
        List<Company> getCompanies();

        Company getCompanyById(int id);

        //Update
        Company updateCompany(Company company);
        
        //Delete
        Company deleteCompany(int id);
    }
}