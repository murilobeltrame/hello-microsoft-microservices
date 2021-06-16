using System;

namespace BookStore.Warehouse.Domain.Entities
{
    public class WarehouseItem
    {
        public WarehouseItem(Book book, int? quantity) => (Book, Quantity) = (book, quantity);

        private Book _book;
        public Book Book
        {
            get => _book;
            init => _book = value != null ? value : throw new ArgumentNullException("", nameof(Book));
        }
        public int? Quantity { get; }
    }
}
