//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manhattan.View.Cliente {
    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    
    
    public partial class MinhaConta : global::Xamarin.Forms.ContentPage {
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry NomeEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry SobrenomeEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry TelefoneEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry CPFEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry UsuarioEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button AlterarButton;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button SalvarButton;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button AlterarSenhaButton;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Button SalvarButtonSenha;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry SenhaEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Manhattan.Behaviors.RequiredValidatorBehavior SenhaEntryValidator;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Entry ConfirmarSenhaEntry;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Manhattan.Behaviors.ComparisonBehavior ConfirmarSenhaEntryBehavior;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            this.LoadFromXaml(typeof(MinhaConta));
            NomeEntry = this.FindByName<global::Xamarin.Forms.Entry>("NomeEntry");
            SobrenomeEntry = this.FindByName<global::Xamarin.Forms.Entry>("SobrenomeEntry");
            TelefoneEntry = this.FindByName<global::Xamarin.Forms.Entry>("TelefoneEntry");
            CPFEntry = this.FindByName<global::Xamarin.Forms.Entry>("CPFEntry");
            UsuarioEntry = this.FindByName<global::Xamarin.Forms.Entry>("UsuarioEntry");
            AlterarButton = this.FindByName<global::Xamarin.Forms.Button>("AlterarButton");
            SalvarButton = this.FindByName<global::Xamarin.Forms.Button>("SalvarButton");
            AlterarSenhaButton = this.FindByName<global::Xamarin.Forms.Button>("AlterarSenhaButton");
            SalvarButtonSenha = this.FindByName<global::Xamarin.Forms.Button>("SalvarButtonSenha");
            SenhaEntry = this.FindByName<global::Xamarin.Forms.Entry>("SenhaEntry");
            SenhaEntryValidator = this.FindByName<global::Manhattan.Behaviors.RequiredValidatorBehavior>("SenhaEntryValidator");
            ConfirmarSenhaEntry = this.FindByName<global::Xamarin.Forms.Entry>("ConfirmarSenhaEntry");
            ConfirmarSenhaEntryBehavior = this.FindByName<global::Manhattan.Behaviors.ComparisonBehavior>("ConfirmarSenhaEntryBehavior");
        }
    }
}
