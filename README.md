# Простейшая криптография реализация

## Описание

Реализация различных криптографических алгоритмов, факторизация числа, быстрая возведение в степень и т.д.(Обновляется)

# Факторизация числа
Данный алгоритм используется для разложения RSA ключей и последуюещего их взлома. Настоящий RSA ключ использует 1024 бита информации, поэтому взломать его может только квантовый компьютер, моя реализация(в случае доработки), сможет раскладывать старый формат RSA ключей где было всего 128 бит информации. Замена данных ключей прошла относительно недавно и можно потренироваться на зашифрованной информации 2007-х годов.

# Факторизация с помощью решета эратосфена 

![Факторизация](https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/New_Animation_Sieve_of_Eratosthenes.gif/400px-New_Animation_Sieve_of_Eratosthenes.gif)

# Быстрое возвеение в степень 
Данный алгоритм позволяет быстро возвести число в степень. Данный алгоритм уже реализован в различных библиотеках на низкоуровневых языках и на высокоуровневых языках. В python встроена функция PowMod, используемая для быстрого возведения в степень.

# P.s. Весь код сделан в обучающих целях
Я не являюсь проффесиональным разработчиком, данные программы сделаны в целях обучения, я никого не призываю использовать данный код как проффесиональный.

# Simplest cryptography implementation

## Description

Implementation of various cryptographic algorithms, factorization of numbers, rapid exponentiation, etc.(Updated)

# Factorization of a number
This algorithm is used to decompose RSA keys and then crack them. A real RSA key uses 1024 bits of information, so only a quantum computer can crack it, my implementation (if finalized) will be able to decompose the old format of RSA keys where there were only 128 bits of information. The replacement of these keys took place relatively recently and you can practice on encrypted information from the 2007's.

# Factorization using the sieve of Eratosthenes

![Факторизация](https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/New_Animation_Sieve_of_Eratosthenes.gif/400px-New_Animation_Sieve_of_Eratosthenes.gif)

# Rapid elevation to a degree 
This algorithm allows you to quickly raise the number to a power. This algorithm has already been implemented in various libraries in low-level languages and in high-level languages. Python has a built-in PowMod function used for fast exponentiation.

# P.s. All the code is made for educational purposes
I am not a professional developer, these programs are made for training purposes, I do not encourage anyone to use this code as professional.
