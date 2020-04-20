﻿//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : DispatcherUtils.cs
// Auteur        : Nicolas Dagnas
// Description   : Implémentation des objets du namespace System.Windows.Threading
// Créé le       : 24/05/2013
// Modifié le    : 02/01/2014
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// Début du bloc "System.Windows.Threading"
//*******************************************************************************************************************************
namespace System.Windows.Threading
	{

    //  ####   #   ####  ####    ###   #####   ###   #   #  #####  #### 
    //  #   #  #  #      #   #  #   #    #    #   #  #   #  #      #   #
    //  #   #  #   ###   ####   #####    #    #      #####  ###    #### 
    //  #   #  #      #  #      #   #    #    #   #  #   #  #      #   #
    //  ####   #  ####   #      #   #    #     ###   #   #  #####  #   #

	//***************************************************************************************************************************
	// Classe DispatcherUtils
	//***************************************************************************************************************************
	#region // Déclaration et Implémentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Fournit un gestionnaire de mise en attente.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public static class DispatcherUtils
		{
		//***********************************************************************************************************************
		/// <summary>
		/// Appel la procédure en mode asynchrone après le délai.
		/// </summary>
		/// <param name="Self">Objet <b>Dispatcher</b>.</param>
		/// <param name="Callback">Procédure à appeler.</param>
		/// <param name="Delay">Délai avant l'appel en millisecondes.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		public static void Async ( this Dispatcher Self, Action Callback, int Delay )
			{
			//-------------------------------------------------------------------------------------------------------------------
			var Timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds ( Delay ) };

			Timer.Tick += (sender, args) => { Timer.Stop (); Callback (); };

			Timer.Start ();
			//-------------------------------------------------------------------------------------------------------------------
			}
		//***********************************************************************************************************************

		//***********************************************************************************************************************
		/// <summary>
		/// Appel la procédure en mode asynchrone.
		/// </summary>
		/// <param name="Self">Objet <b>Dispatcher</b>.</param>
		/// <param name="Callback">Procédure à appeler.</param>
		//-----------------------------------------------------------------------------------------------------------------------
		public static void Async ( this Dispatcher Self, Action Callback )
			{ Self.Async ( Callback, 100 ); }
		//***********************************************************************************************************************
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "System.Windows.Threading"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
