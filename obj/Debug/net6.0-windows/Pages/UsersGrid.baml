   M S B A M L   `   `   `  ????A  =Nastol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NastolNastol  5   	       Nastol.UsersGrid   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Nastol     5   	     ? Title$  	UsersGrid??5   	   $	??700??6   $
??1200??6)    ? WindowStartupLocation$ CenterScreen=?66    ? 
ResizeMode$ CanMinimize=?6[   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $	??170 ?6   6-   ?? 5      6!    ? RowDefinitions 5   
   ?? 5      $??70 ?6   6*   ?? 5      6   ?? 5      $??60 ?6   6*   .+?5   
   ? $??2??6   $??30,0,0,0q?6!   $??1??63   $??Center=?6C   .+?5      ?? -   5        $??Обновить??5      
???????$??1q?6O   $??	25,5,25,5q?6c   $??18(?6w   $??Stretch=?6?   $??0,0,0,5q?6?   5      ?? 5      $??0??6   $??3??6"   
???   ?
???????$??Stretch=?5   9   $??10q?5      $
??Bold"?5      $??30(?5      $/??)Таблица пользователей??5      ? 5   
   $??2??6   $??0??6!   $??0,10,0,0q?62   .+?5      ?? -   5        $??
Назад??5      
???????$??1q?6M   $??	53,5,52,5q?6a   $??18(?6u   $??Stretch=?6?   $??0,0,0,5q?6?   5       &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ UGrid??5"      $??1??6"   $??1??6/   $??0,5,10,0q?6?      
IsReadOnly$
 True??6n   5$      5%      5&      