using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tariff.model;
using Tariff.View;

namespace Tariff.Presenter
{
    class SignUpPresenter
    {
        private TariffData _model;
        private FormSigningUp _view;
        
        public SignUpPresenter(TariffData model, FormSigningUp view)
        {
            _model = model;
            _view = view;

            _view.OpeningMainForm += OnOpeningMainForm;
            _view.CheckingInputData += _model.AccessAdminData;
            //_view.UpdatingTariff += OnUpdatingTariff;
            _model.GettingAccess += OnOpeningAdminForm;
        }

        private void OnOpeningAdminForm(string login, string password)
        {
            AdminForm view = new AdminForm();
            AdminPresenter mainPresenter = new AdminPresenter(_model, view);
            view.ShowDialog();
        }

        private void OnOpeningMainForm()
        {
            Assistant tariffAssistant = new Assistant(_model);
            FormTariffAssistant view = new FormTariffAssistant();
            MainPresenter mainPresenter = new MainPresenter(_model, view,tariffAssistant);
            view.ShowDialog();
        }
    }
}
