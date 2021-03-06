﻿# Мост (Bridge)
**Структурный паттерн** проектирования, который **разделяет** один или несколько классов на **две отдельные иерархии** - **абстракцию и реализацию**, **позволяя изменять их независимо друг от друга**

## Цель:
Разделение одной логической группы на "абстракцию" и "реализацию" для развития её в двух направлениях без всяких проблем

Абстракция (или интерфейс взаимодействия) - образный **слой управления чем-либо**.
Он не делает работу самостоятельно, а **делегирует её слою реализации**. **Именно с этим слоем работает клиент**

Реализация - слой, которым оперирует абстракция. Тут описывается сложная реализация какого-либо продукта, а затем её использует **абстракция**

>Только не путайте эти термины с интерфейсами или абстрактными классами из вашего языка программирования, это не одно и то же.

## Пример
Возьмём в пример реальную программу:
* **Абстракцией** может выступать графический интерфейс программы (GUI)
* **Реализацией** - низкоуровневый код операционной системы (API), к которому графический интерфейс обращается по реакции на действия пользователя.
---
Вы можете **развивать программу в двух разных направлениях**:
* Иметь несколько видов GUI (например, для простых пользователей и администраторов);
* Поддерживать много видов API (например, работать под Windows, Linux и macOS).

## Когда применять
* Когда вы хотите разделить монолитный класс, который содержит несколько различных реализаций какой-то функциональности (например, если класс может работать с разными системами баз данных)
* Когда класс нужно расширять в двух независимых плоскостях
* Когда вы хотите, чтобы реализацию можно было бы изменять во время выполнения программы

## Плюсы и минусы
+|-
----|----
Позволяет строить платформо-независимые программы | Усложняет код программы из-за введения дополнительных классов
Скрывает лишние или опасные **детали реализации** от клиентского кода |
Реализует принцип *открытости/закрытости* |

## Шаги реализации
1. Определите, существует ли в ваших классах два непересекающихся измерения. Это может быть функциональность/платформа, предметная-область/инфраструктура, фронт-энд/бэк-энд или интерфейс/реализация.
2. Продумайте, какие операции будут нужны клиентам, и опишите их в базовом классе абстракции.
3. Определите поведения, доступные на всех платформах, и выделите из них ту часть, которая нужна абстракции. На основании этого опишите общий интерфейс реализации.
4. Для каждой платформы создайте свой класс конкретной реализации. Все они должны следовать общему интерфейсу, который мы выделили перед этим.
5. Добавьте в класс абстракции ссылку на объект реализации. Реализуйте методы абстракции, делегируя основную работу связанному объекту реализации.
6. Если у вас есть несколько вариаций абстракции, создайте для каждой из них свой подкласс.
7. Клиент должен подать объект реализации в конструктор абстракции, чтобы связать их воедино. После этого он может свободно использовать объект абстракции, забыв о реализации.

## Источник
[Подробнее тут](https://refactoring.guru/ru/design-patterns/bridge)

[Википедия](https://ru.wikipedia.org/wiki/%D0%9C%D0%BE%D1%81%D1%82_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F))