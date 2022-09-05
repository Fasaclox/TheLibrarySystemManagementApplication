using LSMWebApi.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LSMWebApi.Repository
{
    public interface ILSMRepository
    {
        //Customers
        Task<List<CustomerModel>> GetAllCustomersAsync();
        Task<CustomerModel> GetCustomerByIdAsync(int Customer_Id);
        Task<int> AddCustomerAsync(CustomerModel customerModel);
        Task DeleteCustomerAsync(int customer_Id);
        Task UpdateCustomerAsync(int customer_Id, CustomerModel customerModel);
        Task UpdateCustomerPatchAsync(int customer_Id, JsonPatchDocument customerModel);

        //Staffs
        Task<List<StaffModel>> GetAllStaffsAsync();
        Task<StaffModel> GetStaffByIdAsync(int Staff_Id);
        Task<int> AddStaffAsync(StaffModel staffModel);
        Task DeleteStaffAsync(int staff_Id);
        Task UpdateStaffAsync(int staff_Id, StaffModel staffModel);
        Task UpdateStaffPatchAsync(int staff_Id, JsonPatchDocument staffModel);

        //Books
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookByIdAsync(int BookISBN_Id);
        Task<int> AddBookAsync(BookModel bookModel);
        Task UpdateBookAsync(int bookISBN_Id, BookModel bookModel);
        Task DeleteBookAsync(int bookISBN_Id);

    }
}
