//*******************************************************************************************************************************
// DEBUT DU FICHIER
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// Nom           : DeviceType.cs
// Auteur        : Nicolas Dagnas
// Description   : Impl�mentation de l'objet DeviceType
// Cr�� le       : 05/03/2015
// Modifi� le    : 05/03/2015
//*******************************************************************************************************************************

//-------------------------------------------------------------------------------------------------------------------------------
#region Using directives
//-------------------------------------------------------------------------------------------------------------------------------
using System;
//-------------------------------------------------------------------------------------------------------------------------------
#endregion
//-------------------------------------------------------------------------------------------------------------------------------

//*******************************************************************************************************************************
// D�but du bloc "System.Windows.Phone.Infos"
//*******************************************************************************************************************************
namespace System.Windows.Phone.Infos
	{

    //  ####   #####  #   #  #   ###   #####         #####  #   #  ####   #####
    //  #   #  #      #   #  #  #   #  #               #     # #   #   #  #    
    //  #   #  ###    #   #  #  #      ###    #####    #      #    ####   ###  
    //  #   #  #       # #   #  #   #  #               #      #    #      #    
    //  ####   #####    #    #   ###   #####           #      #    #      #####

	//***************************************************************************************************************************
	// Classe DeviceType
	//***************************************************************************************************************************
	#region // D�claration et Impl�mentation de l'Objet
	//---------------------------------------------------------------------------------------------------------------------------
	/// <summary>
	/// Permet de g�rer les diff�rentes d�finitions.
	/// </summary>
	//---------------------------------------------------------------------------------------------------------------------------
	public enum DeviceType
		{
		/// <summary>
		/// L'appareil est un smartphone.
		/// </summary>
		SmartPhone,
		/// <summary>
		/// L'appareil est une phablette.
		/// </summary>
		Phablet   ,
		}
	//---------------------------------------------------------------------------------------------------------------------------
	#endregion
	//***************************************************************************************************************************

	} // Fin du namespace "System.Windows.Phone.Infos"
//*******************************************************************************************************************************

//*******************************************************************************************************************************
// FIN DU FICHIER
//*******************************************************************************************************************************
