<h1>Лабораторне заняття № 06</h1> <h2>Об’єктно-орієнтоване програмування</h2> <h3>Тема: Наслідування</h3> <h4>Мета:</h4> Опанування концепції успадкування в об’єктно-орієнтованому програмуванні, вироблення навичок створення ієрархій класів, використання поліморфізму та підвищення рівня розуміння важливості використання успадкування для підтримки повторного використання коду та створення більш гнучких програм в мові програмування C#. <h4>Програмне забезпечення:</h4> ОС Windows/Linux, Visual Studio, Visual Studio Code <h4>Порядок виконання роботи:</h4> <h5>Завдання 1. Книгарня</h5> Вам потрібно створити програму для автоматизації опису книг. Програма повинна включати два класи: 1. **Book**: представляє звичайну книгу, яка має назву, автора та ціну. 2. **GoldenEditionBook**: представляє особливу книгу, ціна якої завжди на 30% вища, ніж у звичайної книги.
Вам потрібно реалізувати перевірку для властивостей класу Book:

Якщо прізвище автора починається на цифру - повідомлення винятку: «Автор не дійсний!»
Якщо довжина заголовка менше 3 символів - повідомлення винятку: «Title not valid!»
Якщо ціна дорівнює нулю або є від'ємною - повідомлення винятку: «Ціна не дійсна!»
Ціна повинна бути відформатована до двох десяткових знаків.

<h5>Завдання 2. Людство</h5> Створіть додаток для моделювання студентів та працівників. Основний клас **Person** повинен мати ім’я та прізвище. Кожен студент має номер факультету, а кожен працівник має тижневу зарплату та кількість робочих годин на день. Працівник також повинен мати можливість розраховувати заробіток за годину.
Перевірки для властивостей:

Ім'я та прізвище повинні починатися з великої літери та бути певної довжини.
Номер факультету повинен містити від 5 до 10 символів.
Тижнева зарплата повинна бути більшою за 10.
Кількість робочих годин повинна бути в межах від 1 до 12.
<h5>Завдання 3. Онлайн-радіо</h5> Розробіть програму для створення бази даних пісень для онлайн-радіостанції. Ви повинні зберігати інформацію про кожну пісню: ім'я виконавця, назву пісні та її тривалість у форматі хвилини:секунди.
Створіть ієрархію винятків для некоректних пісень, таких як InvalidSongException, InvalidArtistNameException, InvalidSongNameException, та InvalidSongLengthException.

Перевірте:

Ім'я виконавця повинно містити від 3 до 20 символів.
Назва пісні повинна містити від 3 до 30 символів.
Тривалість пісні повинна бути від 0 до 14 хвилин 59 секунд.
Після обробки всіх пісень, виведіть кількість доданих пісень і загальну довжину плейлиста.

<h5>Завдання 4. Mordor</h5> Розробіть програму для обчислення настрою Гендальфа на основі спожитої їжі. Їжа має різний вплив на настрій, наприклад: - Сухий хліб: +2 бали щастя - Лембас: +3 бали щастя - Яблуко: +1 бал щастя - Гриби: -10 балів щастя - Інша їжа: -1 бал щастя
Ось можливі стани настрою:

Злий: менше -5 балів щастя
Сумний: від -5 до 0 балів щастя
Щасливий: від 1 до 15 балів щастя
Блаженство: більше 15 балів щастя
Виведіть загальну кількість балів щастя Гендальфа та відповідний настрій.