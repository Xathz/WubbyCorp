using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WubbyCorp.Extensions;
using WubbyCorp.Utilities;

namespace WubbyCorp.Controls {

    public partial class Company : UserControl {

        public Company() {
            InitializeComponent();

            // Not sute if I like the wubbyCado icon on the button or not
            //BuyButton.ImageAlign = ContentAlignment.MiddleRight;
            //BuyButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            //BuyButton.Image = ImageUtils.ResizeImage(Properties.Resources.wubbyCado, 24, 24);
        }

        private void Company_Load(object sender, EventArgs e) {
            SetBuyButtonText();
            ProductionTimer.Start();
        }

        private void BuyButton_Click(object sender, EventArgs e) {
            // TODO Subtract from the total WubbyCados
        }

        private void CompanyLogoPictureBox_Click(object sender, EventArgs e) {
            // TODO Add to the total WubbyCados
        }

        private void ProductionTimer_Tick(object sender, EventArgs e) {
   
        }

        private void SetBuyButtonText() {
            (double value, string dictionaryWord) = (BuyPrice * BuyAmount).ToDictionaryWord();
            BuyButton.Text = $"Buy (x{BuyAmount}) for {((BuyPrice > 999D) ? value.ToString("N2") : value.ToString("N0"))} {((string.IsNullOrEmpty(dictionaryWord)) ? "" : $"{dictionaryWord} ")}WubbyCado{((BuyPrice == 1D) ? "" : "s")}";
        }

        public event PropertyChangedEventHandler MultiplierChanged;
        protected void OnMultiplierChanged(string propertyName) => MultiplierChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private int _Multiplier = 1;
        /// <summary>
        /// Gets or sets the multiplier used to calculate the <see cref="Production"/>.
        /// </summary>
        public int Multiplier {
            get => _Multiplier;
            set {
                if (!(_Multiplier == value)) {
                    _Multiplier = value;
                    OnMultiplierChanged(nameof(Multiplier));
                }
            }
        }

        public event PropertyChangedEventHandler ProductionIntervalChanged;
        protected void OnProductionIntervalChanged(string propertyName) => ProductionIntervalChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private int _ProductionInterval = 5000;
        /// <summary>
        /// Gets or sets how often a production cycle takes in milliseconds.
        /// </summary>
        public int ProductionInterval {
            get => _ProductionInterval;
            set {
                if (!(_ProductionInterval == value)) {
                    _ProductionInterval = value;
                    OnProductionIntervalChanged(nameof(ProductionInterval));

                    if (!(ProductionTimer.Interval == ProductionInterval)) {
                        if (ProductionTimer.Enabled) {
                            ProductionTimer.Stop();
                            ProductionTimer.Interval = ProductionInterval;
                            ProductionTimer.Start();
                        } else {
                            ProductionTimer.Interval = ProductionInterval;
                        }
                    }
                }
            }
        }

        public event PropertyChangedEventHandler ProductionChanged;
        protected void OnProductionChanged(string propertyName) => ProductionChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private double _Production;
        /// <summary>
        /// Gets or sets how many WubbyCados to make in a single <see cref="ProductionInterval"/>.
        /// </summary>
        public double Production {
            get => _Production;
            set {
                if (!(_Production == value)) {
                    _Production = value;
                    OnProductionChanged(nameof(Production));
                }
            }
        }

        public event PropertyChangedEventHandler BuyPriceChanged;
        protected void OnBuyPriceChanged(string propertyName) => BuyPriceChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private double _BuyPrice = 1D;
        /// <summary>
        /// Gets or sets the cost of the next <see cref="CompanyLevel"/> in WubbyCados.
        /// </summary>
        public double BuyPrice {
            get => _BuyPrice;
            set {
                if (!(_BuyPrice == value)) {
                    _BuyPrice = value;
                    OnBuyPriceChanged(nameof(BuyPrice));

                    SetBuyButtonText();
                }
            }
        }

        public event PropertyChangedEventHandler BuyAmountChanged;
        protected void OnBuyAmountChanged(string propertyName) => BuyAmountChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private int _BuyAmount = 1;
        /// <summary>
        /// Gets or sets how many <see cref="CompanyLevel"/> to buy.
        /// </summary>
        public int BuyAmount {
            get => _BuyAmount;
            set {
                if (!(_BuyAmount == value)) {
                    _BuyAmount = value;
                    OnBuyAmountChanged(nameof(BuyAmount));

                    SetBuyButtonText();
                }
            }
        }

        public event PropertyChangedEventHandler BuyButtonEnabledChanged;
        protected void OnBuyButtonEnabledChanged(string propertyName) => BuyButtonEnabledChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Gets or sets a value indicating whether the control can respond to user interaction.
        /// </summary>
        public bool BuyButtonEnabled {
            get => BuyButton.Enabled;
            set {
                if (!(BuyButton.Enabled == value)) {
                    if (BuyButton.InvokeRequired) {
                        Invoke(new Action(() => BuyButton.Enabled = value));
                    } else {
                        BuyButton.Enabled = value;
                    }
                    OnBuyButtonEnabledChanged(nameof(BuyButtonEnabled));
                }
            }
        }

        public event PropertyChangedEventHandler CompanyLogoChanged;
        protected void OnCompanyLogoChanged(string propertyName) => CompanyLogoChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Gets or sets an image for the company logo.
        /// </summary>
        public Image CompanyLogo {
            get => CompanyLogoPictureBox.Image;
            set {
                if (!(CompanyLogoPictureBox.Image == value)) {
                    if (CompanyLogoPictureBox.InvokeRequired) {
                        Invoke(new Action(() => CompanyLogoPictureBox.Image = value));
                    } else {
                        CompanyLogoPictureBox.Image = value;
                    }
                    OnCompanyLogoChanged(nameof(CompanyLogo));
                }
            }
        }

        public event PropertyChangedEventHandler CompanyDisplayNameChanged;
        protected void OnCompanyDisplayNameChanged(string propertyName) => CompanyDisplayNameChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Gets or sets the company display name.
        /// </summary>
        public string CompanyDisplayName {
            get => CompanyDisplayNameLabel.Text;
            set {
                if (!(CompanyDisplayNameLabel.Text == value)) {
                    if (CompanyDisplayNameLabel.InvokeRequired) {
                        Invoke(new Action(() => CompanyDisplayNameLabel.Text = value));
                    } else {
                        CompanyDisplayNameLabel.Text = value;
                    }
                    OnCompanyDisplayNameChanged(nameof(CompanyDisplayName));
                }
            }
        }

        public event PropertyChangedEventHandler CompanyTaglineChanged;
        protected void OnCompanyTaglineChanged(string propertyName) => CompanyTaglineChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Gets or sets the company tagline.
        /// </summary>
        public string CompanyTagline {
            get => CompanyTaglineLabel.Text;
            set {
                if (!(CompanyTaglineLabel.Text == value)) {
                    if (CompanyTaglineLabel.InvokeRequired) {
                        Invoke(new Action(() => CompanyTaglineLabel.Text = value));
                    } else {
                        CompanyTaglineLabel.Text = value;
                    }
                    OnCompanyTaglineChanged(nameof(CompanyTagline));
                }
            }
        }

        public event PropertyChangedEventHandler CompanyLevelChanged;
        protected void OnCompanyLevelChanged(string propertyName) => CompanyLevelChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Gets or sets the company level.
        /// </summary>
        public string CompanyLevel {
            get => CompanyLevelLabel.Text;
            set {
                if (!(CompanyLevelLabel.Text == value)) {
                    if (CompanyLevelLabel.InvokeRequired) {
                        Invoke(new Action(() => CompanyLevelLabel.Text = value));
                    } else {
                        CompanyLevelLabel.Text = value;
                    }
                    OnCompanyLevelChanged(nameof(CompanyLevel));
                }
            }
        }

    }

}
