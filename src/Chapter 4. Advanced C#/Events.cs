namespace Chapter_4._Advanced_C_ {
    public class Events {
        public void EventShow() {
            Console.WriteLine("=== Демонстрация событий в C# ===\n");
            
            Console.WriteLine("Создаем акцию с символом 'THPW':");
            var stock = new Stock("THPW");
            
            Console.WriteLine($"Устанавливаем начальную цену: $27.10");
            stock.Price = 27.10M;
            
            Console.WriteLine("Подписываемся на событие изменения цены...");
            stock.PriceChanged += stock_PriceChanged;
            
            Console.WriteLine($"Изменяем цену на: $31.59");
            stock.Price = 31.59M;
            
            Console.WriteLine("\nЗаметка: События - это специальный вид многоадресных делегатов,");
            Console.WriteLine("которые обеспечивают инкапсуляцию и безопасность при работе с делегатами.\n");
        }

        public void MultipleSubscribers() {
            Console.WriteLine("=== Демонстрация нескольких подписчиков ===\n");
            
            Console.WriteLine("Создаем акцию с символом 'MSFT':");
            var stock = new Stock("MSFT");
            stock.Price = 100.00M;
            
            Console.WriteLine("Подписываем нескольких обработчиков:");
            stock.PriceChanged += (sender, e) => 
                Console.WriteLine($"  Обработчик 1: Цена изменилась с ${e.LastPrice} на ${e.NewPrice}");
            
            stock.PriceChanged += (sender, e) => 
                Console.WriteLine($"  Обработчик 2: Разница составляет ${e.NewPrice - e.LastPrice}");
            
            stock.PriceChanged += stock_PriceChanged;
            
            Console.WriteLine("\nИзменяем цену на $120.00:");
            stock.Price = 120.00M;
            
            Console.WriteLine("\nЗаметка: Все подписчики получают уведомление о событии в порядке подписки.\n");
        }

        void stock_PriceChanged(object sender, PriceChangedEventArgs e) {
            decimal percentChange = (e.NewPrice - e.LastPrice) / e.LastPrice;
            
            if (percentChange > 0.1M)
                Console.WriteLine($"  ПРЕДУПРЕЖДЕНИЕ: Повышение цены акции на {percentChange:P1}!");
        }
    }


    public class PriceChangedEventArgs : EventArgs {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice) {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }

    public class Stock {
        string symbol;
        decimal price;

        public Stock(string symbol) => this.symbol = symbol;

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e) {
            Console.WriteLine($"  [Внутри Stock] Вызываем событие PriceChanged для {symbol}");
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price {
            get => price;
            set {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }
        
        public string Symbol => symbol;
    }
}