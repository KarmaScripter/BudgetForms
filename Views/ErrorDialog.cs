//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetForms
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class ErrorDialog : Form
    {
        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        /// <value>
        /// The exception.
        /// </value>
        public virtual Exception Exception { get; set; }

        public ErrorDialog( )
        {
            InitializeComponent( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDialog"/> class.
        /// </summary>
        /// <param name="ext">The ext.</param>
        public ErrorDialog( Exception ext )
            : this( )
        {
            Exception = ext;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( )
        {
            try
            {
                var _logString = Exception.ToLogString( "" );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( Exception exc )
        {
            try
            {
                var _logString = exc?.ToLogString( "" );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        public void SetText( string msg = "" )
        {
        }

        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">The exception.</param>
        private static void Fail( Exception ex )
        {
            Console.WriteLine( ex.Message );
        }
        
    }
}