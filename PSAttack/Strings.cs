﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAttack
{
    class Strings
    {
        public static string version = "1.0-RC2u1";
        public static string windowTitle = "PSAttack!!";
        public static List<string> psaLogos = new List<string>() {
@"
  _____   _______       _______ _______       _____ _  __
 |  __ \ / ____\ \   /\|__   __|__   __|/\   / ____| |/ /
 | |__) | (___  \ \ /  \  | |     | |  /  \ | |    | ' / 
 |  ___/ \___ \  > / /\ \ | |     | | / /\ \| |    |  <  
 | |     ____) |/ / ____ \| |     | |/ ____ | |____| . \ 
 |_|    |_____//_/_/    \_|_|     |_/_/    \_\_____|_|\_\

",
@"
 (   (                                           )  
 )\ ))\ )   (      *   ) *   )   (       (    ( /(  
(()/(()/(   )\   ` )  /` )  /(   )\      )\   )\()) 
 /(_)/(_)((((_)(  ( )(_)( )(_)((((_)(  (((_)|((_)\  
(_))(_))__)\ _ )\(_(_()(_(_()) )\ _ )\ )\___|_ ((_) 
| _ / __\ (_)_\(_|_   _|_   _| (_)_\(_((/ __| |/ /  
|  _\__ \> / _ \   | |   | |    / _ \  | (__  ' <   
|_| |___/_/_/ \_\  |_|   |_|   /_/ \_\  \___|_|\_\ 

",
@"
           __                                       
 _____ ____\ \  _____ _____ _____ _____ _____ _____ 
|  _  |   __\ \|  _  |_   _|_   _|  _  |     |  |  |
|   __|__   |> |     | | |   | | |     |   --|    -|
|__|  |_____/ /|__|__| |_|   |_| |__|__|_____|__|__|
           /_/                                             

",
@"
   ___  _____   ___ _______________  _______ __
  / _ \/ __\ \ / _ /_  __/_  __/ _ |/ ___/ //_/
 / ____\ \  > / __ |/ /   / / / __ / /__/ ,<   
/_/  /___/ /_/_/ |_/_/   /_/ /_/ |_\___/_/|_|  

",
@"
 ######   #####  #       #    ####### #######    #     #####  #    # 
 #     # #     #  #     # #      #       #      # #   #     # #   #  
 #     # #         #   #   #     #       #     #   #  #       #  #   
 ######   #####     # #     #    #       #    #     # #       ###    
 #             #   #  #######    #       #    ####### #       #  #   
 #       #     #  #   #     #    #       #    #     # #     # #   #  
 #        #####  #    #     #    #       #    #     #  #####  #    # 

                                                                     
",
@"
 ____    ____     __    ______  ______ ______ ______  ____    __  __     
/\  _`\ /\  _`\  /\ `\ /\  _  \/\__  _/\__  _/\  _  \/\  _`\ /\ \/\ \    
\ \ \L\ \ \,\L\_\\ `\ `\ \ \L\ \/_/\ \\/_/\ \\ \ \L\ \ \ \/\_\ \ \/'/'   
 \ \ ,__/\/_\__ \ `\ >  \ \  __ \ \ \ \  \ \ \\ \  __ \ \ \/_/\ \ , <    
  \ \ \/   /\ \L\ \ /  / \ \ \/\ \ \ \ \  \ \ \\ \ \/\ \ \ \L\ \ \ \\`\  
   \ \_\   \ `\____/\_/   \ \_\ \_\ \ \_\  \ \_\\ \_\ \_\ \____/\ \_\ \_\
    \/_/    \/_____\//     \/_/\/_/  \/_/   \/_/ \/_/\/_/\/___/  \/_/\/_/

",
@"
  _   __       ___ ___      _    
 |_) (_  \  /\  |   |  /\  /  |/ 
 |   __) / /--\ |   | /--\ \_ |\ 

",
@"
 ______   ______    _______ _______ _______ _______ _______ _     _ 
(_____ \ / _____)_ (_______(_______(_______(_______(_______(_)   | |
 _____) ( (____ ( \ _______    _       _    _______ _       _____| |
|  ____/ \____ \ ) |  ___  |  | |     | |  |  ___  | |     |  _   _)
| |      _____) (_/| |   | |  | |     | |  | |   | | |_____| |  \ \ 
|_|     (______/   |_|   |_|  |_|     |_|  |_|   |_|\______|_|   \_)
                                 
",
@"
      ___      ___         ___                          ___         ___         ___     
     /  /\    /  /\       /  /\        ___      ___    /  /\       /  /\       /__/|    
    /  /::\  /  /:/_     /  /::\      /  /\    /  /\  /  /::\     /  /:/      |  |:|    
   /  /:/\:\/  /:/ /\   /  /:/\:\    /  /:/   /  /:/ /  /:/\:\   /  /:/       |  |:|    
  /  /:/~/:/  /:/ /::\ /  /:/~/::\  /  /:/   /  /:/ /  /:/~/::\ /  /:/  ___ __|  |:|    
 /__/:/ /:/__/:/ /:/\:/__/:/ /:/\:\/  /::\  /  /::\/__/:/ /:/\:/__/:/  /  //__/\_|:|____
 \  \:\/:/\  \:\/:/~/:\  \:\/:/__\/__/:/\:\/__/:/\:\  \:\/:/__\\  \:\ /  /:\  \:\/:::::/
  \  \::/  \  \::/ /:/ \  \::/    \__\/  \:\__\/  \:\  \::/     \  \:\  /:/ \  \::/~~~~ 
   \  \:\   \__\/ /:/   \  \:\         \  \:\   \  \:\  \:\      \  \:\/:/   \  \:\     
    \  \:\    /__/:/     \  \:\         \__\/    \__\/\  \:\      \  \::/     \  \:\    
     \__\/    \__\/       \__\/                        \__\/       \__\/       \__\/    
                                     
",
@"
   _ \    ___| \ \     \     |    |                 |     | 
  |   | \___ \  \ \   _ \    __|  __|   _` |   __|  |  /  | 
  ___/        |   /  ___ \   |    |    (   |  (       <  _| 
 _|     _____/  _/ _/    _\ \__| \__| \__,_| \___| _|\_\ _) 

" };
        public static string warning = @"
 ############################################################
 #                                                          #
 #  PLEASE NOTE: This is an Release Candidate of PS>Attack  #
 #   Things might be buggy. If you find something that's    #
 #             broken please submit an issue at             #
 #     https://github.com/jaredhaight/psattack/issues       #
 #        or even better, submit a pull request! :-D        #
 #                                                          #
 #         For more info view the release notes at          #
 #   https://www.github.com/jaredhaight/psattack/releases   #
 #                                                          #
 ############################################################

";
        public static string moduleLoadError = "There was an error loading this module \nError message:\n\n{0}\n";
        public static string welcomeMessage = "Welcome to PS>Attack! This is version {0}. \n{1}\nFor help getting started, run 'get-attack'\n";
    }
}
