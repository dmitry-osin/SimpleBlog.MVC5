using System;
using SimpleBlog.DAL.Context;
using SimpleBlog.DAL.DataContracts;
using SimpleBlog.DAL.Repository;

namespace SimpleBlog.DAL.DataService
{
    public class UnitOfWork : IUnitOfWork, IDataContext<ApplicationContext>
    {
        private readonly ApplicationContext _context;

        private bool _disposed;
        private PostRepository _postRepository;
        private TagRepository _tagRepository;
        private SettingRepository _settingRepository;

        /// <summary>
        /// Gets the data context.
        /// </summary>
        /// <value>
        /// The data context.
        /// </value>
        public ApplicationContext DataContext
        {
            get { return _context; }
        }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the posts.
        /// </summary>
        /// <value>
        /// The posts.
        /// </value>
        public PostRepository Posts
        {
            get
            {
                if (_postRepository == null)
                    _postRepository = new PostRepository(_context);
                return _postRepository;
            }
        }


        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public SettingRepository Settings
        {
            get
            {
                if (_settingRepository == null)
                    _settingRepository = new SettingRepository(_context);
                return _settingRepository;
            }
        }


        /// <summary>
        /// Gets the tags.
        /// </summary>
        /// <value>
        /// The tags.
        /// </value>
        public TagRepository Tags
        {
            get
            {
                if (_tagRepository == null)
                    _tagRepository = new TagRepository(_context);
                return _tagRepository;
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                _disposed = true;
            }
        }

        
    }
}