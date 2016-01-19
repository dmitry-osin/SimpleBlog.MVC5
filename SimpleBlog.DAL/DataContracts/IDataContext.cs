namespace SimpleBlog.DAL.DataContracts
{
    public interface IDataContext<T>
    {
        /// <summary>
        /// Gets the data context.
        /// </summary>
        /// <value>
        /// The data context.
        /// </value>
        T DataContext { get; }
    }
}