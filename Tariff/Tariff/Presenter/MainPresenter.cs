using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tariff.model;
using Tariff.View;

namespace Tariff.Presenter
{
    class MainPresenter
    {
        private TariffData _model;
        private FormTariffAssistant _view;

        public MainPresenter(TariffData model, FormTariffAssistant view)
        {
            _model = model;
            _view = view;

            _view.Saving += OnSaving;
            _view.GettingAllTariffs += OnGettingAllTariffs;

            _view.RefreshListBox();
        }

        private void OnGettingTariffData(int id) => _model.FindTariffById(id);

        private IReadOnlyList<IReadOnlyTariff> OnGettingAllTariffs() => _model.GetTariffs();

        private void OnOpeningSigningUpForm()
        {
            //FormSigningUp view = new FormSigningUp();
            AdminForm view = new AdminForm();
            AdminPresenter presenter = new AdminPresenter(_model, view);
            view.ShowDialog();
        }

        private void OnSaving() => _model.Save();
    }
}
