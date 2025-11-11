<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="sole_trader_accounts_preparation.aspx.cs" Inherits="Automation_V1.sole_trader_accounts_preparation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <link href="Content/custom.css" rel="stylesheet" />

    <div class="row">
    <h1>Letter of engagement - sole trader </h1>
    </div>
    <hr />

<div class="row">
    <div class="col-md-12">

             <div class="form-group">              

                   <section>

            <div>
                <p>The proprietor of <input type="text" id="Businessname"
                        name="Businessname"
                        placeholder="Insert Businessname"></p>
                <p>Date: <input type="date" id="engagementDate"
                        name="engagementDate" required></p>

                <p>Dear <input type="text" id="Name" name="Name"
                        placeholder="Insert name">,</p>
                <p>We are pleased to accept the instruction to act as accountant
                    for your business and are writing to confirm the terms of
                    our appointment. </p>
                <p>The purpose of this letter, together with the attached terms
                    and conditions, is to set out our terms for carrying out the
                    work and to clarify our respective responsibilities. </p>
                <p>We are bound by the ethical guidelines of ACCA, and accept
                    instructions to act for you on the basis that we will act in
                    accordance with those ethical guidelines. A copy of these
                    guidelines can be viewed at our offices on request or at <a
                        href="www.accaglobal.com">www.accaglobal.com</a>. </p>
            </div>

            <div>
                <h2>Period of engagement </h2>
                <p>This letter is effective from <input type="date"
                        id="engagementDate" name="engagementDate" required></p>
                <p>We will deal with matters arising in respect of periods prior
                    to the above as appropriate. </p>
            </div>

            <div>
                <h2>Scope of services to be provided</h2>
                <h3>Our responsibility to you </h3>
                <p>We have set out the agreed scope and objectives of your
                    instructions within this letter of engagement. Any
                    subsequent changes will be discussed with you and where
                    appropriate a new letter of engagement will be agreed. We
                    shall proceed on the basis of the instructions we have
                    received from you and will rely on you to tell us as soon as
                    possible if anything occurs which renders any information
                    previously given to us as incorrect or inaccurate. We shall
                    not be responsible for any failure to advise or comment on
                    any matter that falls outside the specific scope of your
                    instructions. We cannot accept any responsibility for any
                    event, loss or situation unless it is one against which it
                    is the expressed purpose of these instructions to provide
                    protection. </p>
                <h3>Your responsibility to us</h3>
                <p>The advice that we give can only be as good as the
                    information on which it is based. In so far as that
                    information is provided by you, or by third parties with
                    your permission, your responsibility arises as soon as
                    possible if any circumstances or facts alter, as any
                    alteration may have a significant impact on the advice
                    given. If the circumstances change therefore or your needs
                    alter, advise us of the alteration as soon as possible in
                    writing. </p>
                <h3>Responsibilities </h3>
                <p>Our function as accountant is to act as agent on your behalf
                    in preparing the accounts (income and expenditure account
                    and balance sheet) of your business.</p>
                <p>Our report will be based on information gained from you, and
                    we accept no responsibility for any losses arising out of
                    implementing our report. Further, our report requires us to
                    rely substantially on your representations. Therefore we can
                    accept no responsibility for any losses for issues not
                    addressed in our report. </p>
                <p>As part of our normal procedures we may request you to
                    provide written confirmation of any oral information and
                    explanations given to us during the course of our work. </p>
            </div>

            <div>
                <h2>Our service to you</h2>
                <p>We will not be carrying out any audit work as part of this
                    assignment and accordingly will not verify the assets and
                    liabilities of the business, nor the items of expenditure
                    and income. To carry out an audit would entail additional
                    work so that we could report on the truth and fairness of
                    the accounts. We would also like to emphasise that we cannot
                    undertake to discover any shortcomings in your systems or
                    irregularities on the part of your employees. </p>
                <p>We have a professional duty to compile accounts that conform
                    with generally accepted accounting principles. Where we
                    identify that the accounts do not conform to accepted
                    accounting principles nor to the specific rules relating to
                    the cash accounting regime we will inform you and suggest
                    amendments be put through the accounts before being
                    published. We have a professional responsibility not to
                    allow our name to be associated with accounts that may be
                    misleading. In extreme cases, where this matter cannot be
                    resolved, we will withdraw from the engagement and notify
                    you in writing. </p>
                <p>To ensure that anyone reading the accounts is aware that we
                    have not carried out an audit, we will attach to the
                    accounts a report stating this fact. </p>
                <p>We will attach to the accounts a report developed by the
                    Consultative Committee of Accountancy Bodies (CCAB) which
                    explains what work has been done by us, the professional
                    requirements we have to fulfil and the standard to which the
                    work has been carried out. Web links are provided in the
                    report so that you can obtain further information from the
                    Association of Chartered Certified Accountants about: </p>
                <ol>
                    <li>The technical guidance for the work, and</li>
                    <li>he related ethical and other professional requirements.
                    </li>
                </ol>
                <p>The intended user of the report is the proprietor. The report
                    will be addressed to the proprietor. </p>
            </div>

            <div>
                <h2>Limitation of liability</h2>
                <p>We specifically draw your attention to the limitation of
                    liability paragraphs in our standard terms and conditions
                    which set out the basis on which we limit our liability to
                    you and to others. You should read this in conjunction with
                    the limitation of third party rights paragraphs in our
                    standard terms and conditions which exclude liability to
                    third parties. These are important provisions which you
                    should read and consider carefully. </p>
                <p>There are no third parties that we have agreed should be
                    entitled to rely on the work done pursuant to this
                    engagement letter. </p>
                <h2>Other services</h2>
                <p>You may request that we provide other services from time to
                    time. If these services will exceed £500, we will issue a
                    separate letter of engagement and scope of work to be
                    performed accordingly. </p>
                <p>Because rules and regulations frequently change, you must ask
                    us to confirm any advice already given if a transaction is
                    delayed or a similar transaction is to be undertaken. </p>
            </div>

            <div>
                <h2>Agreement of terms</h2>
                <p>This letter supersedes any previous engagement letter for the
                    period covered. Once it has been agreed, this letter will
                    remain effective until it is replaced.

                    You or we may vary or terminate our authority to act on your
                    behalf at any time without penalty. Notice of variation or
                    termination must be given in writing. </p>
                <p>We would be grateful if you could confirm your agreement to
                    the terms of this letter by signing the enclosed copy and
                    returning it to us immediately. </p>
                <p>If this letter is not in accordance with your understanding
                    of the scope of our engagement or your circumstances have
                    changed, please let us know. </p>
                <p>This letter should be read in conjunction with the firm’s
                    standard terms and conditions. </p>
            </div>

            <div>
                <p>Yours sincerely <br>
                    Signed,</p>
                <p class="signature">Martin R Watt</p>
                <p><strong>Martin R Watt FCCA </strong><br>
                    Thyme Tax & Accountancy Ltd </p>

            </div>

            <div class="signature-section">
                <p>I confirm that I have read and understood the contents of
                    this letter and related terms and conditions and agree that
                    it accurately reflects my fair understanding of the services
                    that I require you to undertake.</p>
                <p><canvas id="signature-pad" width="400" height="200"
                        style="border:1px solid #000;"></canvas>
                    <button id="clear">Clear</button>
                    <button id="save">Save</button>

                    <script
                        src="https://cdn.jsdelivr.net/npm/signature_pad@2.3.2/dist/signature_pad.min.js"></script>
                    <script>
                        var canvas = document.getElementById('signature-pad');
                        var signaturePad = new SignaturePad(canvas);

                        // Clear signature
                        document.getElementById('clear').addEventListener('click', function () {
                            signaturePad.clear();
                        });

                        // Save signature
                        document.getElementById('save').addEventListener('click', function () {
                            if (signaturePad.isEmpty()) {
                                alert("Please provide a signature first.");
                            } else {
                                var dataURL = signaturePad.toDataURL();
                                console.log(dataURL);  // This is where you can send the signature to your server or save it
                            }
                        });
                    </script>
                </p>
                <p>Date: <input type="date" id="PeriodofEngagement"
                        name="PeriodofEngagement" required></p>
                <p>For and on behalf of <strong><input type="text"
                            id="businessname" name="businessname"
                            placeholder="Insert business name"></strong></p>
            </div>

        </section>


            </div>

             <asp:HiddenField ID="txtContractnumber" runat="server"/>

            <br/>

        <asp:CheckBox ID="chkContract" runat="server" />
 
         <asp:Button ID="btnSubmit" class="btn custom-btn" runat="server" Text="Accept" 
                             Width="82px" OnClick="btnSubmit_Click" />

            </div>
    </div>

    <script>
    function alertupdate() {
        swal("Company Created Succesfully", '', "success",);
    }
    </script>

</asp:Content>
