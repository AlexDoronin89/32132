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
        private Assistant _tariffAssistant;

        public MainPresenter(TariffData model, FormTariffAssistant view, Assistant tariffAssistant)
        {
            _model = model;
            _view = view;
            _tariffAssistant = tariffAssistant;

            _view.Saving += OnSaving;
            _view.ChoosingRightTariff += OnChoosingRightTariff;
            _tariffAssistant.ChoseRightTariff += OnChoseRightTariff;

            _view.RefreshListBox(OnGettingAllTariffs());
        }

        private void OnGettingTariffData(int id) => _model.FindTariffById(id);

        private IReadOnlyList<IReadOnlyTariff> OnGettingAllTariffs() => _model.GetTariffs();

        private void OnChoosingRightTariff(int gygabytes, int minutes , int messages) => _tariffAssistant.ChooseRightTariff(gygabytes, minutes, messages);

        private void OnChoseRightTariff(IReadOnlyList<IReadOnlyTariff> tariffs) => _view.RefreshListBox(tariffs);

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
