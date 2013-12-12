using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookCatalogService.Data;
using BookCatalogService.Domain;
using IBookCatalogService.Data;
using IBookCatalogService.Domain;

namespace BookCatalogService.Process
{
    // Poor Man's DI Illustration
    public class FetchBookProcessLegacy
    {
        public IBookDetail FetchByIndex(int index)
        {
            DatabaseConnectionProvider connProvider = new DatabaseConnectionProvider();
            FetchBookProvider bookProvider = new FetchBookProvider(new SqlResourceLoader());
            BookDataManager bookDataManager = new BookDataManager(connProvider, bookProvider);
            return bookDataManager.FetchBookByIndex(index);
        }
    }

    // Poor Man's DI Illustration
    public class PoorMansDIFetchBookProcess
    {
        private IDatabaseConnectionProvider  _connProvider;
        private IFetchBookProvider           _bookProvider;
        private IBookDataManager             _bookDataManager;

        public PoorMansDIFetchBookProcess()
        {
            _connProvider       = new DatabaseConnectionProvider();  
            _bookProvider       = new FetchBookProvider(new SqlResourceLoader());
            _bookDataManager    = new BookDataManager(_connProvider, _bookProvider);
        }

        public PoorMansDIFetchBookProcess(
            IDatabaseConnectionProvider connProvider,
            IFetchBookProvider bookProvider
            )
        {
            _connProvider = connProvider;
            _bookProvider = bookProvider;
            _bookDataManager = new BookDataManager(_connProvider, _bookProvider);
        }

        public PoorMansDIFetchBookProcess(
           IBookDataManager manager
           )
        {
            _bookDataManager = manager;
        }
        
        public IBookDetail FetchByIndex(int index)
        {
           return _bookDataManager.FetchBookByIndex(index);
        }
    }


}
