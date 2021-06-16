using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Warehouse.Domain.Entities
{
    public record Book
    {
        public Book(
            string title,
            IEnumerable<Author> authors,
            Publisher publisher,
            ushort? pages = null
        ) => (Title, Authors, Publisher, Pages) = (title, authors, publisher, pages);

        private IEnumerable<Author> _authors;
        public IEnumerable<Author> Authors
        {
            get => _authors;
            init => _authors = (value?.Any()).GetValueOrDefault() ? value : throw new ArgumentException("", nameof(Authors));
        }

        private Publisher _publisher;
        public Publisher Publisher
        {
            get => _publisher;
            init => _publisher = value ?? throw new ArgumentException("", nameof(Publisher));
        }

        private string _title;
        public string Title
        {
            get => _title;
            init => _title = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentNullException(nameof(Title));
        }

        public ushort? Pages { get; }
    }
}
