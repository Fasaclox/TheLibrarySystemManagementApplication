using AutoMapper;
using LSMWebApi.Context;
using LSMWebApi.Data;
using LSMWebApi.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSMWebApi.Repository
{
    public class LSMRepository : ILSMRepository
    {
        private readonly LSMContext _context;
        private readonly IMapper _mapper;
        public LSMRepository(LSMContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        //Customers
        public async Task<List<CustomerModel>> GetAllCustomersAsync()
        {
            var records = await _context.Customers.ToListAsync();
            return _mapper.Map<List<CustomerModel>>(records);
        }
        public async Task<CustomerModel> GetCustomerByIdAsync(int Customer_Id)
        {
            var customer = await _context.Staffs.FindAsync(Customer_Id);
            return _mapper.Map<CustomerModel>(customer);
        }
        //Books
        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var records = await _context.Books.ToListAsync();
            return _mapper.Map<List<BookModel>>(records);
        }
        public async Task<BookModel> GetBookByIdAsync(int BookISBN_Id)
        {
            var book = await _context.Books.FindAsync(BookISBN_Id);
            return _mapper.Map<BookModel>(book);
        }



        //Staffs
        public async Task<List<StaffModel>> GetAllStaffsAsync()
        {
            var records = await _context.Staffs.ToListAsync();
            return _mapper.Map<List<StaffModel>>(records);
        }

        public async Task<StaffModel> GetStaffByIdAsync(int Staff_Id)
        {
            var staff = await _context.Staffs.FindAsync(Staff_Id);
            return _mapper.Map<StaffModel>(staff);
        }
        public async Task<int> AddStaffAsync(StaffModel staffModel)
        {
            var staff = new Staff()
            {
                First_Name = staffModel.First_Name,
                Last_Name = staffModel.Last_Name,
                Middle_Name = staffModel.Middle_Name,
                Gender = staffModel.Gender,
                Designation = staffModel.Designation,
                Is_Admin = staffModel.Is_Admin,
                Address = staffModel.Address,
                Email = staffModel.Email,
                Phone_Number = staffModel.Phone_Number,
                Date_Created = staffModel.Date_Created,
                Date_Deleted = staffModel.Date_Deleted,
                Date_Edited = staffModel.Date_Edited,

            };
            _context.Staffs.Add(staff);
            await _context.SaveChangesAsync();
            return staff.Staff_Id;
        }

        public async Task DeleteStaffAsync(int staff_Id)
        {
            var staff = new Staff() { Staff_Id = staff_Id };
            _context.Staffs.Remove(staff);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateStaffAsync(int staff_Id, StaffModel staffModel)
        {
            var staff = new Staff();
           
            {
                staff.Staff_Id = staffModel.Staff_Id;   
                staff.First_Name = staffModel.First_Name;
                staff.Last_Name = staffModel.Last_Name;
                staff.Middle_Name = staffModel.Middle_Name;
                staff.Gender = staffModel.Gender;
                staff.Designation = staffModel.Designation;
                staff.Is_Admin = staffModel.Is_Admin;
                staff.Address = staffModel.Address;
                staff.Email = staffModel.Email;
                staff.Phone_Number = staffModel.Phone_Number;
                staff.Date_Created = staffModel.Date_Created;
                staff.Date_Deleted = staffModel.Date_Deleted;
                staff.Date_Edited = staffModel.Date_Edited;

            };

            _context.Staffs.Update(staff);
            await _context.SaveChangesAsync();


        }
        public async Task UpdateStaffPatchAsync(int staff_Id, JsonPatchDocument staffModel) 
        {
            var staff = await _context.Staffs.FindAsync(staff_Id);
            if (staff != null) 
            {
                staffModel.ApplyTo(staff);
                await _context.SaveChangesAsync();
            
            }


        }
        //Customer 
        public async Task<int> AddCustomerAsync(CustomerModel customerModel)
        {
            var customer = new Customer()
            {
                First_Name = customerModel.First_Name,
                Last_Name = customerModel.Last_Name,
                Middle_Name = customerModel.Middle_Name,
                Gender = customerModel.Gender,
                Occupation = customerModel.Occupation,
                Staff_Id = customerModel.Staff_Id,
                Address = customerModel.Address,
                Email = customerModel.Email,
                Phone_Number = customerModel.Phone_Number,
                Date_Created = customerModel.Date_Created,
                Date_Deleted = customerModel.Date_Deleted,
                Date_Edited = customerModel.Date_Edited,

            };
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer.Customer_Id;
        }

        public async Task DeleteCustomerAsync(int customer_Id)
        {
            var customer = new Customer() { Customer_Id = customer_Id };
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomerAsync(int customer_Id, CustomerModel customerModel)
        {
            var customer = new Customer();

            {
                customer.First_Name = customerModel.First_Name;
                customer.Last_Name = customerModel.Last_Name;
                customer.Middle_Name = customerModel.Middle_Name;
                customer.Gender = customerModel.Gender;
                customer.Occupation = customerModel.Occupation;
                customer.Staff_Id = customerModel.Staff_Id;
                customer.Address = customerModel.Address;
                customer.Email = customerModel.Email;
                customer.Phone_Number = customerModel.Phone_Number;
                customer.Date_Created = customerModel.Date_Created;
                customer.Date_Deleted = customerModel.Date_Deleted;
                customer.Date_Edited = customerModel.Date_Edited;


            };

            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();


        }
        public async Task UpdateCustomerPatchAsync(int customer_Id, JsonPatchDocument customerModel)
        {
            var customer = await _context.Customers.FindAsync(customer_Id);
            if (customer != null)
            {
                customerModel.ApplyTo(customer);
                await _context.SaveChangesAsync();

            }


        }
        //Books
        public async Task<int> AddBookAsync(BookModel bookModel)
        {
            var book = new Book()
            {

                BookISBN_Id = bookModel.BookISBN_Id,
                Category_Id = bookModel.Category_Id,
                Binding_Id = bookModel.Binding_Id,
                Author = bookModel.Author,
                Shelf_Id = bookModel.Shelf_Id,
                Edition = bookModel.Edition,
                Number_Current_Copies = bookModel.Number_Current_Copies,
                Date_Created = bookModel.Date_Created,
                Date_Deleted = bookModel.Date_Deleted,
                Date_Edited = bookModel.Date_Edited,
                Number_Actual_Copies = bookModel.Number_Actual_Copies,
                Year_Published = bookModel.Year_Published,
                Language = bookModel.Language

        };
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book.BookISBN_Id;
        }

        public async Task DeleteBookAsync(int bookISBN_Id)
        {
            var book = new Book() { BookISBN_Id = bookISBN_Id };
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(int bookISBN_Id, BookModel bookModel)
        {
            var book = new Book();

            {
                book.BookISBN_Id = bookModel.BookISBN_Id;
                book.Category_Id = bookModel.Category_Id;
                book.Binding_Id = bookModel.Binding_Id; 
                book.Author = bookModel.Author;
                book.Shelf_Id = bookModel.Shelf_Id;
                book.Edition = bookModel.Edition;
                book.Number_Current_Copies = bookModel.Number_Current_Copies;
                book.Date_Created = bookModel.Date_Created;
                book.Date_Deleted = bookModel.Date_Deleted;
                book.Date_Edited = bookModel.Date_Edited;
                book.Number_Actual_Copies = bookModel.Number_Actual_Copies;
                book.Year_Published = bookModel.Year_Published;
                book.Language = bookModel.Language;

            };

            _context.Books.Update(book);
            await _context.SaveChangesAsync();


        }
        public async Task UpdateBookPatchAsync(int bookISBN_Id, JsonPatchDocument bookModel)
        {
            var book = await _context.Books.FindAsync(bookISBN_Id);
            if (book != null)
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();

            }


        }
    }
   


}
