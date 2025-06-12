Модуль загрузки одежды из сдк.

<b>Установка</b>
1. Установите модули: https://github.com/Welwise-Games/ClothesShared_Module и https://github.com/Welwise-Games/WelwiseGamesSDK
2. Установите пакет по пути Package Manager -> Add package from git URL -> https://github.com/Welwise-Games/LoadingClothes_Module.git

<b>Код</b><br>
Если класс пишется с маленькой буквы, значит имеется ввиду название инстанса. 

Создайте контроллер смены одежды (в readme clothes shared модуля написано как), передав данные через вызов sdk.PlayerData.GetEquippedItemsDataFromMetaverse();
