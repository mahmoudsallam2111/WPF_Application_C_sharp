   M S B A M L   `   `   `  ????D  @day1_task, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:day1_task	day1_task  5   	       day1_task.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:day1_task     5   	   -   5        $
??form??5        ? Title$  
login form??6	   $	??600??6(   $	??800??65   
??????? ? 
ResizeMode$ NoResize=?6S   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $??100px ?6   6/   ?? 5      $??* ?6   6+    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   6-   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   ?? 5      $
??Auto ?6   6,   .+?5   
   ?? -   5         ??Name$ fn_txt??5      $??1??6#   $??Center=?66   $??30??6Q   $??39,10,278,10q?6]   ?? 5   
   $??20(?6   $??Oblique$?6   $??	fristname??62   $??Center=?6F   $??Center=?6c   ?? 5   
   -   5        $ ln_txt??5      $??2??6"   $??1??62   $??Center=?6B   $??30??6]   $??39,10,278,10q?6i   ?? 5   
   $??20(?6   $??Oblique$?6   $??lastname??62   $??1??6E   $??Center=?6R   $??Center=?6o   ?? 5    
   -   5        $ 
gender_txt??5       $??1??6&   $??2??66   $??Center=?6F   $??30??6a   $??39,10,278,10q?6m   ?? 5!   
   $??20(?6   $??Oblique$?6   $??gender??62   $??2??6C   $??Center=?6P   $??Center=?6m   ?? 5"   
   -   5        $ add_txt??5"      $??1??6#   $??3??63   $??Center=?6B   $??30??6]   $??39,10,278,10q?6i   ?? 5#   
   $??20(?6   $??Oblique$?6   $??address??62   $??3??6D   $??Center=?6Q   $??Center=?6n   ?? 5$   
   -   5        $ 	phone_txt??5$      $??1??6%   $??4??65   $??Center=?6D   $??30??6_   $??39,10,278,10q?6k   ?? 5%   
   $??20(?6   $??Oblique$?6   $??phone??62   $??4??6B   $??Center=?6O   $??Center=?6l   ?? 5&   
   -   5        $ 
mobile_txt??5&      $??1??6&   $??5??66   $??Center=?6F   $??30??6a   $??39,10,278,10q?6m   ?? 5'   
   $??20(?6   $??Oblique$?6   $??mobile??62   $??5??6C   $??Center=?6P   $??Center=?6m   ?? 5(   
   -   5        $ em_txt??5(      $??1??6"   $??6??62   $??Center=?6@   $??30??6[   $??39,10,278,10q?6g   ?? 5)   
   $??20(?6   $??Oblique$?6   $??email??62   $??6??6B   $??Center=?6O   $??Center=?6l   ?? 5*   
   -	   5        $ jt_txt??5*      $??1??6"   $??7??62   $	??Top=?6A   $??30??6Y   $??39,10,278,10q?6e   ?? 5+   
   $??20(?6   $??Oblique$?6   $??	job title??62   $??7??6F   $
??Left=?6S   $	??Top=?6n   $??	21,12,0,0q?6?   ?? 5,   
   -
   5        
??? ? ?$??1??5,   3   $
??okay??6C   $
??Left=?6R   $??163,122,0,0q?6m   $??7??6?   $??72??6?   ?? 5-   
   -   5        
???  ??$??1??5-   6   $??cancle??6F   $
??Left=?6W   $??280,121,0,0q?6r   $??7??6?   $	??Top=?6?   $??30??6?   $??86??6?   5/      50      