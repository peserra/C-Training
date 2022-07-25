using System;
namespace Inheritance {
    // magazine is subclass of publication
    class Magazine : Publication {
        private string publisher;
        // constructor should have the : base()
        public Magazine(string name, string publisher, int pageCount, decimal price) : base (name, pageCount, price) {
            this.publisher = publisher;
        }
        public string Publisher {
            get => this.publisher;
            set => this.publisher = value;
        }

    }
}