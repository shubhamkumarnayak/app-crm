﻿// The MIT License (MIT)
// 
// Copyright (c) 2015 Xamarin
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System.Linq;
using System.Web.Http;
using XamarinCRM.Models;

namespace XamarinCRMAppService.Controllers
{
    public class AccountController : BaseController<Account>
    {
        // GET tables/Account
        public IQueryable<Account> GetAllAccount()
        {
            return Query(); 
        }

        // GET tables/Account/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Account> GetAccount(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Account/48D68C86-6EA6-4C25-AA33-223FC9A27959
        // Omitted intentionally to prevent PATCH operations
        //public Task<Account> PatchAccount(string id, Delta<Account> patch)
        //{
        //     return UpdateAsync(id, patch);
        //}

        // POST tables/Account
        // Omitted intentionally to prevent POST operations
        //public async Task<IHttpActionResult> PostAccount(Account item)
        //{
        //    Account current = await InsertAsync(item);
        //    return CreatedAtRoute("Tables", new { id = current.Id }, current);
        //}

        // DELETE tables/Account/48D68C86-6EA6-4C25-AA33-223FC9A27959
        // Omitted intentionally to prevent DELETE operations
        //public Task DeleteAccount(string id)
        //{
        //     return DeleteAsync(id);
        //}
    }
}
