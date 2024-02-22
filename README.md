![C#](https://img.shields.io/badge/-CSharp-262424?style=for-the-badge&logo=CSharp&logoColor=684D95)
# Контрольное домашнее задание №3.2 (работа с событиями)

## 1) Вспомогательная информация

- Более удобной практикой будет тестирование на **большем** интервале, чем 15 секунд 
(поменять константу `INTERVAL` в `Lib.Entities.AutoSaver.cs` )
- Файл `data.json` находится в папке `assets` корневого каталога

## 2) Дополнительные реализации

### 2.1) [Схема проекта в Figma](https://www.figma.com/file/AQh1E1o80nYUt77hB8O68O/CHW_3_2?type=design&node-id=0%3A1&mode=design&t=iyYSjVMPSAm8CpZL-1)

### 2.2) Сортировка вложенных объектов (Repairs в Machine)

#### `Lib.Data.Storage.Sort.cs`

### 2.3) Генератор новых уникальных id (как в шаблоне) для новых Repairs

#### `Lib.Utils.GetAvaliableId.cs`

### 2.4) Вывод сущностей на основе введенных id в ***различных форматах***

#### `Application.Services.ShowService.cs`
#### `Application.Handlers.ShowHandler.cs`