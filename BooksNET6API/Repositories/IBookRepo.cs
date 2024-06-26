﻿using BooksNET6API.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksNET6API.Repositories
{
    public interface IBookRepo
    {
        Task<ActionResult<IEnumerable<Book>>> GetBooks();
        Task<ActionResult<Book>> GetBook(int id);
        Task<IActionResult> PutBook(int id, Book book);
        Task<ActionResult<Book>> PostBook(Book book);
        Task<IActionResult> DeleteBook(int id);
    }
}
