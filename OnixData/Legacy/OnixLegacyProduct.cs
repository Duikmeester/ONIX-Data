﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixData.Legacy
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class OnixLegacyProduct
    {
        #region CONSTANTS

        public const int CONST_PRODUCT_TYPE_PROP   = 1;
        public const int CONST_PRODUCT_TYPE_ISBN   = 2;
        public const int CONST_PRODUCT_TYPE_EAN    = 3;
        public const int CONST_PRODUCT_TYPE_UPC    = 4;
        public const int CONST_PRODUCT_TYPE_ISMN   = 5;
        public const int CONST_PRODUCT_TYPE_DOI    = 6;
        public const int CONST_PRODUCT_TYPE_LCCN   = 13;
        public const int CONST_PRODUCT_TYPE_GTIN   = 14;
        public const int CONST_PRODUCT_TYPE_ISBN13 = 15;

        #endregion

        public OnixLegacyProduct()
        {
            RecordReference  = 0;
            NotificationType = -1;

            ProductIdentifier = new OnixLegacyProductId[0];

            ProductForm       = "";
            ProductFormDetail = "";

            ProductFormFeature = new OnixLegacyProductFormFeature();

            ProductFormDescription = "";

            Title       = new OnixLegacyTitle();
            Contributor = new OnixLegacyContributor[0];

            ContributorStatement = "";

            Language = new OnixLegacyLanguage();

            NumberOfPages = -1;

            Illustrations = new OnixLegacyIllustrations();

            BASICMainSubject = "";

            Subject = new OnixLegacySubject();

            OtherText = new OnixLegacyOtherText[0];
            MediaFile = new OnixLegacyMediaFile[0];

            Imprint   = new OnixLegacyImprint();
            Publisher = new OnixLegacyPublisher();

            PublicationDate = 0;

            Measure = new OnixLegacyMeasure[0];

            RelatedProduct = new OnixLegacyRelatedProduct();
            SupplyDetail   = new OnixLegacySupplyDetail();
        }

        private ulong recordReferenceField;
        private int   notificationTypeField;

        private string isbnField;
        private string eanField;
        private string upcField;

        private OnixLegacyProductId[] productIdentifierField;

        private string productFormField;
        private string productFormDetailField;

        private OnixLegacyProductFormFeature productFormFeatureField;

        private string productFormDescriptionField;

        private OnixLegacyTitle         titleField;
        private OnixLegacyContributor[] contributorField;

        private string contributorStatementField;

        private OnixLegacyLanguage languageField;

        private int numberOfPagesField;

        private OnixLegacyIllustrations illustrationsField;

        private string bASICMainSubjectField;

        private OnixLegacySubject subjectField;

        private OnixLegacyOtherText[] otherTextField;

        private OnixLegacyMediaFile[] mediaFileField;

        private OnixLegacyImprint imprintField;

        private OnixLegacyPublisher publisherField;

        private uint publicationDateField;

        private OnixLegacyMeasure[] measureField;

        private OnixLegacyRelatedProduct relatedProductField;

        private OnixLegacySupplyDetail supplyDetailField;

        /// <remarks/>
        public ulong RecordReference
        {
            get
            {
                return this.recordReferenceField;
            }
            set
            {
                this.recordReferenceField = value;
            }
        }

        /// <remarks/>
        public int NotificationType
        {
            get
            {
                return this.notificationTypeField;
            }
            set
            {
                this.notificationTypeField = value;
            }
        }

        public string ISBN
        {
            get
            {
                string TempISBN = this.isbnField;

                if (String.IsNullOrEmpty(TempISBN))
                {
                    if ((ProductIdentifier != null) && (ProductIdentifier.Length > 0))
                    {
                        OnixLegacyProductId IsbnProductId = 
                            ProductIdentifier.Where(x => x.ProductIDType == CONST_PRODUCT_TYPE_ISBN).FirstOrDefault();

                        if ((IsbnProductId != null) && !String.IsNullOrEmpty(IsbnProductId.IDValue))
                            TempISBN = this.isbnField = IsbnProductId.IDValue;
                    }
                }

                return TempISBN;
            }
            set
            {
                this.isbnField = value;
            }
        }

        public string EAN
        {
            get
            {
                string TempEAN = this.eanField;

                if (String.IsNullOrEmpty(TempEAN))
                {
                    if ((ProductIdentifier != null) && (ProductIdentifier.Length > 0))
                    {
                        OnixLegacyProductId EanProductId =
                            ProductIdentifier.Where(x => (x.ProductIDType == CONST_PRODUCT_TYPE_EAN) || 
                                                         (x.ProductIDType == CONST_PRODUCT_TYPE_ISBN13)).FirstOrDefault();

                        if ((EanProductId != null) && !String.IsNullOrEmpty(EanProductId.IDValue))
                            TempEAN = this.eanField = EanProductId.IDValue;
                    }
                }

                return TempEAN;
            }
            set
            {
                this.eanField = value;
            }
        }

        public string UPC
        {
            get
            {
                string TempUPC = this.upcField;

                if (String.IsNullOrEmpty(TempUPC))
                {
                    if ((ProductIdentifier != null) && (ProductIdentifier.Length > 0))
                    {
                        OnixLegacyProductId UpcProductId =
                            ProductIdentifier.Where(x => x.ProductIDType == CONST_PRODUCT_TYPE_UPC).FirstOrDefault();

                        if ((UpcProductId != null) && !String.IsNullOrEmpty(UpcProductId.IDValue))
                            TempUPC = this.upcField = UpcProductId.IDValue;
                    }
                }

                return TempUPC;
            }
            set
            {
                this.upcField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductIdentifier")]
        public OnixLegacyProductId[] ProductIdentifier
        {
            get
            {
                return this.productIdentifierField;
            }
            set
            {
                this.productIdentifierField = value;
            }
        }

        /// <remarks/>
        public string ProductForm
        {
            get
            {
                return this.productFormField;
            }
            set
            {
                this.productFormField = value;
            }
        }

        /// <remarks/>
        public string ProductFormDetail
        {
            get
            {
                return this.productFormDetailField;
            }
            set
            {
                this.productFormDetailField = value;
            }
        }

        /// <remarks/>
        public OnixLegacyProductFormFeature ProductFormFeature
        {
            get
            {
                return this.productFormFeatureField;
            }
            set
            {
                this.productFormFeatureField = value;
            }
        }

        /// <remarks/>
        public string ProductFormDescription
        {
            get
            {
                return this.productFormDescriptionField;
            }
            set
            {
                this.productFormDescriptionField = value;
            }
        }

        /// <remarks/>
        public OnixLegacyTitle Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contributor")]
        public OnixLegacyContributor[] Contributor
        {
            get
            {
                return this.contributorField;
            }
            set
            {
                this.contributorField = value;
            }
        }

        /// <remarks/>
        public string ContributorStatement
        {
            get
            {
                return this.contributorStatementField;
            }
            set
            {
                this.contributorStatementField = value;
            }
        }

        /// <remarks/>
        public OnixLegacyLanguage Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public int NumberOfPages
        {
            get
            {
                return this.numberOfPagesField;
            }
            set
            {
                this.numberOfPagesField = value;
            }
        }

        /// <remarks/>
        public OnixLegacyIllustrations Illustrations
        {
            get
            {
                return this.illustrationsField;
            }
            set
            {
                this.illustrationsField = value;
            }
        }

        /// <remarks/>
        public string BASICMainSubject
        {
            get
            {
                return this.bASICMainSubjectField;
            }
            set
            {
                this.bASICMainSubjectField = value;
            }
        }

        /// <remarks/>
        public OnixLegacySubject Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherText")]
        public OnixLegacyOtherText[] OtherText
        {
            get
            {
                return this.otherTextField;
            }
            set
            {
                this.otherTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MediaFile")]
        public OnixLegacyMediaFile[] MediaFile
        {
            get
            {
                return this.mediaFileField;
            }
            set
            {
                this.mediaFileField = value;
            }
        }

        /// <remarks/>
        public OnixLegacyImprint Imprint
        {
            get
            {
                return this.imprintField;
            }
            set
            {
                this.imprintField = value;
            }
        }

        /// <remarks/>
        public OnixLegacyPublisher Publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        public uint PublicationDate
        {
            get
            {
                return this.publicationDateField;
            }
            set
            {
                this.publicationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Measure")]
        public OnixLegacyMeasure[] Measure
        {
            get
            {
                return this.measureField;
            }
            set
            {
                this.measureField = value;
            }
        }

        /// <remarks/>
        public OnixLegacyRelatedProduct RelatedProduct
        {
            get
            {
                return this.relatedProductField;
            }
            set
            {
                this.relatedProductField = value;
            }
        }

        /// <remarks/>
        public OnixLegacySupplyDetail SupplyDetail
        {
            get
            {
                return this.supplyDetailField;
            }
            set
            {
                this.supplyDetailField = value;
            }
        }
    }
}
